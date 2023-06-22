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
        private List<SupplierModel> suppliers;
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
            BindSupData();
        }

        public void BindSupData()
        {
            SupGridView.Rows.Clear();
            foreach (var supplier in suppliers)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(SupGridView,
                    supplier.SupplierID,
                    supplier.SupName,
                    "Detail");
                SupGridView.Rows.Add(row);
            }
        }

        private void SupGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    string supID = SupGridView.Rows[e.RowIndex].Cells["gvSupplierID"].Value.ToString();
                    SupplierModel supData = suppliers.Where(sup => sup.SupplierID == supID).FirstOrDefault();
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
    }
}
