﻿using Client.Controller;
using Client.Model.Local;
using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Helper.PDF;
using System.Text.RegularExpressions;
using Org.BouncyCastle.Ocsp;

namespace Client.UI.Purchase
{
    public partial class BPApurchase : Form
    {
        private SupplierModel _suppliers;
        private List<BpaListModel> bpaList;
        private PurchaseController purchaseController = new PurchaseController();
        private int id;
        private string[] refNumber;
        public BPApurchase(SupplierModel suppliers)
        {
            InitializeComponent();
            _suppliers = suppliers;
            BindData();
        }

        public async void BindData()
        {
            BindSupplier();
            bpaList = await purchaseController.getBPA(_suppliers.SupplierID);
            if (bpaList == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindBPA();
        }

        public void BindSupplier()
        {
            supIDTxt.Text = _suppliers.SupplierID;
            supNameTxt.Text = _suppliers.SupName;
            SupConNameTxt.Text = _suppliers.contact_Name;
            supConEmailTxt.Text = _suppliers.contact_Email;
            supConNumTxt.Text = _suppliers.contact_Phone;
            supAddressTxt.Text = _suppliers.address;
        }

        public void BindBPA()
        {
            foreach (var item in bpaList)
            {
                bpaIDselect.Items.Add(item.ID + $" ({item.refsupNum})");
            }
        }

        public void BindBPAinfo(List<BpaItemListModel> items)
        {
            BPAviewGrid.Rows.Clear();
            foreach (BpaItemListModel item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(BPAviewGrid,
                    item.ItemID,
                    item.refSupID,
                    item.ItemName,
                    item.unit,
                    item.MOQ,
                    "",
                    item.price);
                BPAviewGrid.Rows.Add(row);
            }
        }

        private void bpaIDselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("\\s");
            string[] regexData = regex.Split(bpaIDselect.SelectedItem.ToString());
            string bpaID = regexData[0].Trim();
            id = int.Parse(bpaID);
                BpaListModel bpaitem = bpaList.Where(data => data.ID == id).FirstOrDefault();
                BindBPAinfo(bpaitem.items);
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            BPAGenModel bpaGenModel = new BPAGenModel();
            bpaGenModel.items = new List<BPAitemGenModel>();
            bpaGenModel.Supplier = _suppliers;
            bpaGenModel.BPAid = id;
            string refNum = bpaList.Where(item => item.ID == id).Select(item => item.refsupNum).FirstOrDefault();
            bpaGenModel.refNum = refNum;
            foreach (DataGridViewRow row in BPAviewGrid.Rows)
            {
                double qty;
                double MOQ = double.Parse(row.Cells["moqGrid"].Value.ToString());
                string itemID = row.Cells["ItemIDdata"].Value.ToString();
                string itemName = row.Cells["ItemIDdata"].Value.ToString();
                string unit = row.Cells["unitGrid"].Value.ToString();
                string refSupID = row.Cells["refSupItemID"].Value.ToString();
                double price = double.Parse(row.Cells["priceGrid"].Value.ToString());
                if (!double.TryParse(row.Cells["quantityGrid"].Value.ToString(),out qty))
                {
                    MessageBox.Show("incorrect qty \n Item ID:  " + itemID);
                    return;
                }

                if (MOQ > qty)
                {
                    MessageBox.Show("Can't smaller than MOQ\n item ID: " + itemID);
                    return;
                }
                
                BPAitemGenModel items = new BPAitemGenModel
                {
                    ItemID = itemID,
                    ItemName = itemName,
                    MOQ = MOQ,
                    unit = unit,
                    price = price,
                    qty = qty,
                    refSupID = refSupID
                };
                bpaGenModel.items.Add(items);
            }

            BPAPDF gen = new BPAPDF(bpaGenModel);
        }
    }
}
