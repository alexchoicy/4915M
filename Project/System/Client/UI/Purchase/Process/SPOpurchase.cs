using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Helper.PDF;
using Client.Model.Local;
using Client.Model.Receive;
using Client.Model.Submit;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace Client.UI.Purchase.Process
{
    public partial class SPOpurchase : Form
    {
        private List<spoListModel> ListData;
        private SupplierPurModel _suppliers;
        private List<ReqspoModel> contract;
        private PurchaseController purchaseController = new PurchaseController();
        private string id;
        public SPOpurchase(SupplierPurModel _suppliers ,List<spoListModel> itemID)
        {
            this._suppliers = _suppliers;
            ListData = itemID;
            InitializeComponent();
            getNeedData();
            spoDGV.CellValueChanged += spoDGV_CellValueChanged;
        }

        public async void getNeedData()
        {
            BindSupplier();
            contract = await purchaseController.getSpoConData(_suppliers.SupplierID);
            if (contract == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindGV();
            getNewpID();
            BindCon();
        }

        public void BindSupplier()
        {
            supIDTxt.Text = _suppliers.SupplierID;
            supNameTxt.Text = _suppliers.SupName;
            SupConNameTxt.Text = _suppliers.Contact_Name;
            supConEmailTxt.Text = _suppliers.Contact_Email;
            supConNumTxt.Text = _suppliers.Contact_Phone;
            supAddressTxt.Text = _suppliers.address;
        }
        public void BindGV()
        {
            spoDGV.Rows.Clear();
            foreach (spoListModel item in ListData)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(spoDGV,
                    item.ItemID,
                    $"{item.ItemName} / {item.unit}",
                    "",
                    item.price,
                    "",
                    "Remove");
                spoDGV.Rows.Add(row);
            }
        }
        public void BindCon()
        {
            foreach (var item in contract)
            {
                conIDselect.Items.Add(item.contractID + $" ({item.refsupNum})");
            }
        }
        public async void getNewpID()
        {
            string pid = await purchaseController.getNewpID(_suppliers.SupplierID);
            pIDTxt.Text = pid;
        }

        public void UpdatePrice(int row)
        {
            double price;
            double qty;
            if(double.TryParse(spoDGV.Rows[row].Cells[3].Value.ToString(),out price))
                if (double.TryParse(spoDGV.Rows[row].Cells[2].Value.ToString(), out qty))
                    spoDGV.Rows[row].Cells[4].Value = price * qty;
        }

        private void conIDselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("\\s");
            string[] regexData = regex.Split(conIDselect.SelectedItem.ToString());
            id = regexData[0].Trim();
            ReqspoModel bpaitem = contract.Where(data => data.contractID == id).FirstOrDefault();
            refTxt.Text = regexData[1].Trim('(', ')');
        }

        private void spoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
                spoDGV.Rows.RemoveAt(e.RowIndex);
        }
        private void spoDGV_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double Reqqty;
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                if (double.TryParse(spoDGV.Rows[e.RowIndex].Cells[2].Value.ToString(), out Reqqty))
                    UpdatePrice(e.RowIndex);
        }

        private async void sumBtn_Click(object sender, EventArgs e)
        {
            string refConSupNum = refTxt.Text;
            string pID = pIDTxt.Text;
            SPOGenModel spogenModel = new SPOGenModel();
            spogenModel.pid = pIDTxt.Text;
            spogenModel.conID = contract.Where(item => item.refsupNum == refTxt.Text).Select(item => item.contractID)
                .FirstOrDefault();
            spogenModel.Supplier = _suppliers;
            spogenModel.item = new List<SPOitemGenModel>();
            spogenModel.refSupConID = refConSupNum;
            foreach (DataGridViewRow row in spoDGV.Rows)
            {
                double price;
                double qty;
                double totalprice;
                string itemID = row.Cells["ItemIDGV"].Value.ToString();
                string itemName = row.Cells["itemNameGV"].Value.ToString();
                string rawqty = row.Cells["qtyGV"].Value.ToString();
                string rawprice = row.Cells["priceGV"].Value.ToString();
                string rawTotalPrice = row.Cells["totalPriceGV"].Value.ToString();
                string refSupID = ListData.Where(item => item.ItemID == itemID).Select(item => item.refSupID)
                    .FirstOrDefault();
                if (!double.TryParse(rawqty, out qty))
                {
                    MessageBox.Show("incorrect qty \n Item ID:  " + itemID);
                    return;
                }

                if (qty < 0)
                {
                    MessageBox.Show("Can't smaller than 0 \n item ID: " + itemID);
                    return;
                }
                totalprice = double.Parse(rawTotalPrice);
                price = double.Parse(rawprice);

                SPOitemGenModel items = new SPOitemGenModel
                {
                    ItemID = itemID,
                    ItemName = itemName,
                    price = price,
                    qty = qty,
                    refSupID = refSupID,
                    Totalprice = totalprice
                };
                spogenModel.item.Add(items);
            }

            SPOPDF gen = new SPOPDF(spogenModel);
            if (!gen.getStatus())
            {
                MessageBox.Show("Error");
                return;
            }
            await gen.generate();
            if (!gen.getStatus())
            {
                MessageBox.Show("Cancelled");
                return;
            }
            PurchaseSumbitModel sumbit = new PurchaseSumbitModel();
            sumbit.item = new List<itemSumbitModel>();
            sumbit.data = new SumbitDataModel
            {
                pid = pID,
                refAggreNum = refConSupNum,
                Type = "SPO",
                supID = _suppliers.SupplierID
            };
            foreach (var item in spogenModel.item)
            {
                itemSumbitModel itemData = new itemSumbitModel
                {
                    itemID = item.ItemID,
                    pID = pID,
                    qty = item.qty,
                    TotalPrice = item.Totalprice
                };
                sumbit.item.Add(itemData);
            }
            string jsonString = JsonSerializer.Serialize(sumbit);
            bool request = await purchaseController.CreateNewPurchase(jsonString, pID, gen.GetNewDocs());
            if (!request)
            {
                MessageBox.Show("Error");
                return;
            }
            MessageBox.Show("Success, the information will send to accounting department");
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
