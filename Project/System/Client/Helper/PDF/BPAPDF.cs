using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Controller;
using Client.Model.Local;
using iText.Kernel.Pdf;
using iText.Bouncycastle;
using iText.Forms;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Utils;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Client.Helper.PDF
{
    public class BPAPDF
    {
        private ContractController conController = new ContractController();
        private BPAGenModel bpaGenModel;
        private byte[] docs;
        public BPAPDF(BPAGenModel _bpaGenModel)
        {
            bpaGenModel = _bpaGenModel;
            InitializeAsync();
        }
        public async void InitializeAsync()
        {
            await GetDocsinBytes();
            Debug.WriteLine(bpaGenModel.BPAid);
            Debug.WriteLine(docs);

            // Call gen() method after docs have been assigned
            gen();
        }
        public void gen()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "demo.pdf");
            PdfWriter writer = new PdfWriter(filePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);
            Paragraph header = new Paragraph("Yummy Restaurant Group Limited")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(20);
            document.Add(header);
            Paragraph address = new Paragraph("Address: " + GlobalData.UserInfo.address);
            document.Add(address);
            Paragraph subheader = new Paragraph("Blanket Purchase Agreement")
                .SetTextAlignment(TextAlignment.CENTER)
                .SetFontSize(15);
            document.Add(subheader);
            Paragraph refNum = new Paragraph($"Reference Agreement Number: {bpaGenModel.refNum}");
            document.Add(refNum);
            Paragraph today = new Paragraph("Create Day: " + DateTime.Now.Date.ToString("d"));
            document.Add(today);
            //Lines
            LineSeparator ls = new LineSeparator(new SolidLine());
            document.Add(ls);
            document.Add(new Paragraph($"Supplier: {bpaGenModel.Supplier.SupName}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetMarginTop(20));
            document.Add(ls);
            Table table = new Table(5, true);
            Cell cellRefID = new Cell()
                .Add(new Paragraph("Item ID"));
            Cell Description = new Cell()
                .Add(new Paragraph("Description"));
            Cell itemName = new Cell()
                .Add(new Paragraph("Item Name"));
            Cell cellqty = new Cell()
                .Add(new Paragraph("Item Qty"));
            Cell cellprice = new Cell()
                .Add(new Paragraph("Item Price"));
            table.AddHeaderCell(cellRefID);
            table.AddHeaderCell(Description);
            table.AddHeaderCell(itemName);
            table.AddHeaderCell(cellqty);
            table.AddHeaderCell(cellprice);
            foreach (var bpaitem in bpaGenModel.items)
            {
                Cell refID = new Cell()
                    .Add(new Paragraph(bpaitem.refSupID));
                Cell localID = new Cell()
                    .Add(new Paragraph($"YRGL ref ID: {bpaitem.ItemID}"));
                Cell itemNameCell = new Cell()
                    .Add(new Paragraph(bpaitem.ItemName + " / " + bpaitem.unit));
                Cell itemqtyCell = new Cell()
                    .Add(new Paragraph(bpaitem.qty.ToString()));
                Cell itempriceCell = new Cell()
                    .Add(new Paragraph(bpaitem.price.ToString()));
                table.AddCell(refID);
                table.AddCell(localID);
                table.AddCell(itemNameCell);
                table.AddCell(itemqtyCell);
                table.AddCell(itempriceCell);
            }

            document.Add(table);
            //Merge pdf
            MemoryStream memory = new MemoryStream(docs);
            PdfDocument pdfDoc = new PdfDocument(new PdfReader(memory));
            document.Add(new AreaBreak(AreaBreakType.NEXT_PAGE));
            pdfDoc.CopyPagesTo(1, pdfDoc.GetNumberOfPages(), document.GetPdfDocument());
            pdfDoc.Close();
            document.Close();
        }

        public async Task GetDocsinBytes()
        {
            docs = await conController.GetDocsinBytes(bpaGenModel.BPAid);
        }
    }
    
}
