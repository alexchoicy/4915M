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
            siCateBox.Items.Add("All");
            siCateBox.SelectedIndex = 0;
        }

        public async void GetData()
        {
            records = await purchaseController.getRecord();
            if (records == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindData(records);
            serachSuggestion();
        }

        public void BindData(List<PurchaseRecord> filterItem)
        {
            hisDGV.Rows.Clear();
            foreach (var record in filterItem)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(hisDGV,
                    record.pid,
                    record.supID,
                    record.Type,
                    record.date.ToString("d"),
                    "Detail");
                hisDGV.Rows.Add(row);
                if (!siCateBox.Items.Contains(record.Type))
                {
                    siCateBox.Items.Add(record.Type);
                }
            }
        }

        private void serachSuggestion()
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (PurchaseRecord item in records)
            {
                ac.Add(item.pid);
                ac.Add(item.supID);
            }
            siSearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            siSearchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            siSearchBox.AutoCompleteCustomSource = ac;
            siSearchBox.TextChanged += siSearchBox_TextChanged;
        }
        private void siSearchBox_TextChanged(object sender, EventArgs e)
        {
            string serachText = siSearchBox.Text.Trim().ToLower();
            List<PurchaseRecord> filterItem = records
                .Where(item =>
                    item.pid.ToLower().Contains(serachText) ||
                    item.supID.ToLower().Contains(serachText))
                .ToList();
            BindData(filterItem);
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
