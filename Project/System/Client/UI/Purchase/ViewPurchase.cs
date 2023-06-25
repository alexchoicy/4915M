using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model.Receive;
using Client.UI.Item;

namespace Client.UI.Purchase
{
    public partial class ViewPurchase : Form
    {
        private PurchaseController purchaseController = new PurchaseController();
        private List<SupplierPurModel> suppliers;
        private Main mainForm;
        public ViewPurchase(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            GetSupData();
        }

        public async void GetSupData()
        {
            suppliers = await purchaseController.getSupplier();
            if (suppliers == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindSupData(suppliers);
            search();
        }

        public void BindSupData(List<SupplierPurModel> filterItem)
        {
            SupGridView.Rows.Clear();
            foreach (var supplier in filterItem)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(SupGridView,
                    supplier.exist,
                    supplier.SupplierID,
                    supplier.SupName,
                    "Detail");
                SupGridView.Rows.Add(row);
            }
        }

        public void search()
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (SupplierPurModel item in suppliers)
            {
                ac.Add(item.SupName);
                ac.Add(item.SupplierID);
            }

            siSearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            siSearchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            siSearchBox.AutoCompleteCustomSource = ac;
            siSearchBox.TextChanged += acItemTxt_TextChanged;
        }
        private void acItemTxt_TextChanged(object sender, EventArgs e)
        {
            string serachText = siSearchBox.Text.Trim().ToLower();
            List<SupplierPurModel> filterItem = suppliers
                .Where(item =>
                    item.SupName.ToLower().Contains(serachText) ||
                    item.SupplierID.ToLower().Contains(serachText))
                .ToList();
            BindSupData(filterItem);
        }

        private void SupGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 3)
                {
                    string supID = SupGridView.Rows[e.RowIndex].Cells["gvSupplierID"].Value.ToString();
                    SupplierPurModel supData = suppliers.Where(sup => sup.SupplierID == supID).FirstOrDefault();
                    Form itemDetailForm = new PurchaseItem(supData);
                    itemDetailForm.ShowDialog();
                    GetSupData();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void viewHistBtn_Click(object sender, EventArgs e)
        {
            Form PurHist = new PurchaseHistory();
            PurHist.ShowDialog();
        }
    }
}
