using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Client.Helper.PDF
{
    public class BPAPDF
    {
        private ContractController conController = new ContractController();
        private BPAGenModel bpaGenModel;
        private byte[] docs;
        private bool status;
        private byte[] newdocs;
        private string Path;
        public BPAPDF(BPAGenModel _bpaGenModel)
        {
            bpaGenModel = _bpaGenModel;
        }

        public async Task generate()
        {
            await InitializeAsync();
        }
        public async Task InitializeAsync()
        {
            await GetDocsinBytes();
            Debug.WriteLine(bpaGenModel.BPAid);
            Debug.WriteLine(docs);
            await getSaveLocal();
            // Call gen() method after docs have been assigned
            gen();
        }

        public async Task getSaveLocal()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "pdf";
            saveDialog.FileName = bpaGenModel.pid + ".pdf";
            saveDialog.AddExtension = true;
            if (saveDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Cancelled");
                status = false;
                return;
            }
            Path = saveDialog.FileName;
        }
        public void gen()
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                PdfWriter writer = new PdfWriter(memoryStream);
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
                Paragraph purNum = new Paragraph($"Reference Purchase Number: {bpaGenModel.pid}");
                document.Add(purNum);
                Paragraph today = new Paragraph("Create Day: " + DateTime.Now.Date.ToString("d"));
                document.Add(today);
                //Lines
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);
                document.Add(new Paragraph($"Supplier: {bpaGenModel.Supplier.SupName}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetMarginTop(20));
                Paragraph refNum = new Paragraph($"Reference Agreement Number: {bpaGenModel.refNum}");
                document.Add(refNum);
                LineSeparator ls2 = new LineSeparator(new SolidLine());
                document.Add(ls2);
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
                status = true;
                newdocs = memoryStream.ToArray();
                File.WriteAllBytes(Path, newdocs);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task GetDocsinBytes()
        {
            docs = await conController.GetDocsinBytes(bpaGenModel.BPAid);
        }

        public bool getStatus()
        {
            return status;
        }

        public byte[] GetNewDocs()
        {
            return newdocs;
        }
    }
    
}
