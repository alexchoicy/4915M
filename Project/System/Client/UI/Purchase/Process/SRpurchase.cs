using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;
using System.Text.RegularExpressions;
using Client.Helper;
using Client.Helper.PDF;
using Client.Model.Local;
using Client.Model.Submit;

namespace Client.UI.Purchase.Process
{
    public partial class SRpurchase : Form
    {
        private SupplierPurModel _suppliers;
        private PurchaseController purchaseController = new PurchaseController();
        private PPAInfo _ppalistModels;
        private int id;
        public SRpurchase(SupplierPurModel suppliers)
        {
            InitializeComponent();
            _suppliers = suppliers;
            BindData();
            getNewpID();
            shipAddTxt.Text = GlobalData.UserInfo.address;
        }
        public async void BindData()
        {
            BindSupplier();
            _ppalistModels = await purchaseController.getPPA(_suppliers.SupplierID);
            if (_ppalistModels == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindPPA();
            BinDrestSelect();
        }

        public async void getNewpID()
        {
            string pid = await purchaseController.getNewpID(_suppliers.SupplierID);
            pIDTxt.Text = pid;
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

        public void BindPPA()
        {
            foreach (var item in _ppalistModels.ppa)
            {
                PPAIDselect.Items.Add(item.ID + $" ({item.refsupPPANum}) ({item.ContractID})");
            }
        }

        public void BindPPAinfo(List<PPAListItemModel> items)
        {
            ppaDGV.Rows.Clear();
            foreach (PPAListItemModel item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ppaDGV,
                    item.ItemID,
                    $"{item.ItemName} / {item.unit}",
                    item.qty,
                    item.price);
                ppaDGV.Rows.Add(row);
            }
        }

        public void BinDrestSelect()
        {
            foreach (var rest in _ppalistModels.restAddress)
            {
                restSelect.Items.Add($"{rest.restId} ({rest.restName})");
            }
        }

        private void PPAIDselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("\\s");
            string[] regexData = regex.Split(PPAIDselect.SelectedItem.ToString());
            string ppaID = regexData[0].Trim();
            id = int.Parse(ppaID);
            PPAListModel ppaitem = _ppalistModels.ppa.Where(data => data.ID == id).FirstOrDefault();
            BindPPAinfo(ppaitem.items);

            refTxt.Text = regexData[1].Trim('(', ')');
        }

        private void restSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("\\s");

            string[] regexData = regex.Split(restSelect.SelectedItem.ToString());
            string restID = regexData[0].Trim();
            ppaRestAddressModel addresses = _ppalistModels.restAddress.Where(data => data.restId == restID).FirstOrDefault();
            shipAddTxt.Text = addresses.restAddress;
        }

        private async void sumBtn_Click(object sender, EventArgs e)
        {
            string pid = pIDTxt.Text;
            string conid = _ppalistModels.ppa.Where(x => x.ID == id).Select(x => x.ContractID).FirstOrDefault();
            Debug.WriteLine(conid);
            string shipName = _ppalistModels.restAddress.Where(x => x.restAddress == shipAddTxt.Text).Select(x => x.restName).FirstOrDefault();
            string shipAddress = shipAddTxt.Text;
            string refSupConID = refTxt.Text;
            SRGenModel srgenModel = new SRGenModel();
            srgenModel.Supplier = _suppliers;
            srgenModel.pid = pid;
            srgenModel.conID = conid;
            srgenModel.refSupConID = refSupConID;
            srgenModel.shipName = shipName;
            srgenModel.shipAddress = shipAddress;
            srgenModel.item = new List<SRitemGenModel>();
            List<PPAListItemModel> items = _ppalistModels.ppa.Where(x => x.refsupPPANum == refSupConID).SelectMany(x => x.items).ToList();
            foreach (DataGridViewRow row in ppaDGV.Rows)
            {
                double price;
                double qty;
                string itemID = row.Cells["ItemIDGV"].Value.ToString();
                string itemName = row.Cells["itemNameGV"].Value.ToString();
                string rawqty = row.Cells["qtyGV"].Value.ToString();
                string rawprice = row.Cells["priceGV"].Value.ToString();
                string refSupID = items.Where(x => x.ItemID == itemID).Select(x => x.refSupID).FirstOrDefault();
                price = double.Parse(rawprice);
                qty = double.Parse(rawqty);
                SRitemGenModel item = new SRitemGenModel
                {
                    ItemID = itemID,
                    ItemName = itemName,
                    price = price,
                    qty = qty,
                    refSupID = refSupID
                };
                srgenModel.item.Add(item);
            }

            SRPDF gen = new SRPDF(srgenModel);
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
                pid = pid,
                refAggreNum = refSupConID,
                Type = "SR",
                supID = _suppliers.SupplierID
            };
            foreach (var item in srgenModel.item)
            {
                itemSumbitModel itemData = new itemSumbitModel
                {
                    itemID = item.ItemID,
                    pID = pid,
                    qty = item.qty,
                    TotalPrice = item.price
                };
                sumbit.item.Add(itemData);
            }
            string jsonString = JsonSerializer.Serialize(sumbit);
            bool request = await purchaseController.CreateNewPurchase(jsonString, pid, gen.GetNewDocs());
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
