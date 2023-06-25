using Client.Model.Local;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using Client.Controller;
using iText.Kernel.Pdf;
using System.IO;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Bouncycastle;


namespace Client.Helper.PDF
{
    public class SPOPDF
    {
        private SPOGenModel _model;
        private ContractController conController = new ContractController();
        private byte[] docs;
        private bool status;
        private byte[] newdocs;
        private string Path;
        public SPOPDF(SPOGenModel genModel)
        {
            _model = genModel;
            status = true;
        }

        public async Task generate()
        {
            await InitializeAsync();
        }

        public async Task InitializeAsync()
        {
            await GetDocsinBytes();
            await getSaveLocal();
            // Call gen() method after docs have been assigned
            if (!status)
            {
                return;
            }
            gen();
        }
        public async Task getSaveLocal()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "pdf";
            saveDialog.FileName = _model.pid + ".pdf";
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
                Paragraph subheader = new Paragraph("Standard Purchase Order")
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetFontSize(15);
                document.Add(subheader);
                Paragraph purNum = new Paragraph($"Reference Purchase Number: {_model.pid}");
                document.Add(purNum);
                Paragraph today = new Paragraph("Create Day: " + DateTime.Now.Date.ToString("d"));
                document.Add(today);
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);
                document.Add(new Paragraph($"Supplier: {_model.Supplier.SupName}")
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetMarginTop(20));
                Paragraph refNum = new Paragraph($"Reference Contract Number: {_model.refSupConID}");
                document.Add(refNum);
                LineSeparator ls2 = new LineSeparator(new SolidLine());
                document.Add(ls2);
                Table table = new Table(6, true);
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
                Cell ceeltotal = new Cell()
                    .Add(new Paragraph("TotalPrice"));
                table.AddHeaderCell(cellRefID);
                table.AddHeaderCell(Description);
                table.AddHeaderCell(itemName);
                table.AddHeaderCell(cellqty);
                table.AddHeaderCell(cellprice);
                table.AddHeaderCell(ceeltotal);
                foreach (var item in _model.item)
                {
                    Cell refID = new Cell()
                        .Add(new Paragraph(item.refSupID));
                    Cell localID = new Cell()
                        .Add(new Paragraph($"YRGL ref ID: {item.ItemID}"));
                    Cell itemNameCell = new Cell()
                        .Add(new Paragraph(item.ItemName));
                    Cell itemqtyCell = new Cell()
                        .Add(new Paragraph(item.qty.ToString()));
                    Cell itempriceCell = new Cell()
                        .Add(new Paragraph(item.price.ToString()));
                    Cell itemtotalCell = new Cell()
                        .Add(new Paragraph(item.Totalprice.ToString()));
                    table.AddCell(refID);
                    table.AddCell(localID);
                    table.AddCell(itemNameCell);
                    table.AddCell(itemqtyCell);
                    table.AddCell(itempriceCell);
                    table.AddCell(itemtotalCell);
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
            docs = await conController.GetConDocsinBytes(_model.conID);

            if (docs == null || docs.Length == 0)
            {
                MessageBox.Show("Failed to retrieve document data.");
                status = false;
            }
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
