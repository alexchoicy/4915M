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
using Client.Model.Submit;

namespace Client.UI.Purchase.Process
{
    public partial class SPOpurchase : Form
    {
        private List<spoListModel> ListData;
        private SupplierModel _suppliers;
        private PurchaseController purchaseController = new PurchaseController();
        public SPOpurchase(SupplierModel _suppliers ,List<spoListModel> itemID)
        {
            this._suppliers = _suppliers;
            ListData = itemID;
            InitializeComponent();
            getNeedData();
        }

        public async void getNeedData()
        {
            BindSupplier();
            //ListData = await purchaseController.getSpoData(_suppliers.SupplierID,itemID);
            if (ListData == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindGV();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
