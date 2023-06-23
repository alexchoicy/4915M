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
using Client.UI.Purchase.History;

namespace Client.UI.Purchase
{
    public partial class PurchaseHistory : Form
    {
        private List<PurchaseRecord> records;
        private PurchaseController purchaseController = new PurchaseController();
        public PurchaseHistory()
        {
            InitializeComponent();
            GetData();
        }

        public async void GetData()
        {
            records = await purchaseController.getRecord();
            if (records == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindData();
        }

        public void BindData()
        {
            hisDGV.Rows.Clear();
            foreach (var record in records)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(hisDGV,
                    record.pid,
                    record.supID,
                    record.Type,
                    record.date.ToString("d"),
                    "Detail");
                hisDGV.Rows.Add(row);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    String pid = hisDGV.Rows[e.RowIndex].Cells["pIDDataGrid"].Value.ToString();
                    Form purDetailForm = new PurchaseHistoryDetail(pid);
                    purDetailForm.ShowDialog();
                    GetData();
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
