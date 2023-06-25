using Client.Controller;
using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UI.Purchase.Process;
using Client.Model.Submit;
using iText.Layout.Element;

namespace Client.UI.Purchase
{
    public partial class PurchaseItem : Form
    {
        private PurchaseController purchaseController = new PurchaseController();
        private SupplierPurModel _suppliers;
        private List<PurchaseItemModel> items;
        private bool checkall;
        public PurchaseItem(SupplierPurModel suppliers)
        {
            InitializeComponent();
            _suppliers = suppliers;
            GetItemData();
        }

        public async void GetItemData()
        {
            items = await purchaseController.getItem(_suppliers.SupplierID);
            if (items == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindItemData(items);
            serachSuggestion();
        }

        public void BindItemData(List<PurchaseItemModel> filterItem)
        {
            itemDataGrid.Rows.Clear();
            foreach (PurchaseItemModel item in filterItem)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemDataGrid,
                    false,
                    item.itemID,
                    item.itemName,
                    item.itemQty);
                itemDataGrid.Rows.Add(row);
            }
        }

        private void BPAcreateBtn_Click(object sender, EventArgs e)
        {
            Form bpaPurchase = new BPApurchase(_suppliers);
            bpaPurchase.FormClosed += bpaPurchase_Close;
            bpaPurchase.ShowDialog();
        }

        private void serachSuggestion()
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (PurchaseItemModel item in items)
            {
                ac.Add(item.itemID);
                ac.Add(item.itemName);
            }
            siSearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            siSearchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            siSearchBox.AutoCompleteCustomSource = ac;
            siSearchBox.TextChanged += siSearchBox_TextChanged;
        }
        private void siSearchBox_TextChanged(object sender, EventArgs e)
        {
            string serachText = siSearchBox.Text.Trim().ToLower();
            List<PurchaseItemModel> filterItem = items
                .Where(item =>
                    item.itemID.ToLower().Contains(serachText) ||
                    item.itemName.ToLower().Contains(serachText))
                .ToList();
            BindItemData(filterItem);
        }
        private void bpaPurchase_Close(object sender, FormClosedEventArgs e)
        {
            GetItemData();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void spoBtn_Click(object sender, EventArgs e)
        {
            List<reqspoModel> itemID = new List<reqspoModel>();
            foreach (DataGridViewRow row in itemDataGrid.Rows)
            {
                if (Convert.ToBoolean(row.Cells["selectItem"].Value))
                {
                    itemID.Add(new reqspoModel
                    {
                        itemID = row.Cells["itemIDGrid"].Value.ToString(),
                    });
                    Debug.WriteLine(row.Cells["itemIDGrid"].Value.ToString());
                }
            }

            if (itemID.Count < 0)
            {
                return;
            }

            List<spoListModel> ListData = await purchaseController.getSpoData(_suppliers.SupplierID, itemID);
            if (ListData == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            Form spoPurchase = new SPOpurchase(_suppliers, ListData);
            spoPurchase.FormClosed += bpaPurchase_Close;
            spoPurchase.ShowDialog();
        }

        private void srbtn_Click(object sender, EventArgs e)
        {
            Form sRpurchase = new SRpurchase(_suppliers);
            sRpurchase.FormClosed += bpaPurchase_Close;
            sRpurchase.ShowDialog();
        }

        private void selectAllBtn_Click(object sender, EventArgs e)
        {
            if (checkall)
            {
                foreach (DataGridViewRow row in itemDataGrid.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = false;
                }
                checkall = false;
            }
            else
            {
                foreach (DataGridViewRow row in itemDataGrid.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                    chk.Value = true;
                }
                checkall = true;
            }
        }
    }
}
