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
        private SupplierModel _suppliers;
        private List<PurchaseItemModel> items;
        public PurchaseItem(SupplierModel suppliers)
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
            BindItemData();
        }

        public void BindItemData()
        {
            itemDataGrid.Rows.Clear();
            foreach (PurchaseItemModel item in items)
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
            Form spoPurchase = new SPOpurchase(_suppliers, ListData);
            spoPurchase.FormClosed += bpaPurchase_Close;
            spoPurchase.ShowDialog();
        }
    }
}
