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
using Client.UI.Contract;

namespace Client.UI.Purchase.History
{
    public partial class PurchaseHistoryDetail : Form
    {
        private PurchaseController purchaseController = new PurchaseController();
        private Model.Receive.History history;
        public PurchaseHistoryDetail(string pid)
        {
            InitializeComponent();
            getData(pid);
        }

        public async void getData(string pid)
        {
            history = await purchaseController.getRecordbyID(pid);
            if (history == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindData();
        }

        public void BindData()
        {
            SupIDTxt.Text = history.record.supID;
            cdcontractIdTxt.Text = history.record.refAggreNum;
            typeTxt.Text = history.record.Type;
            dateTxt.Text = history.record.date.ToString("d");
            BindGV();
        }

        public void BindGV()
        {
            GV.Rows.Clear();
            foreach (var record in history.items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(GV,
                    record.itemID,
                    $"{record.itemName} / {record.UOM}",
                    record.qty,
                    record.TotalPrice,
                    "Detail");
                GV.Rows.Add(row);
            }
        }

        private void acDetailBtn_Click(object sender, EventArgs e)
        {
            if (history.record.Type == "BPA")
            {
                Form conDetailForm = new BPADetail(history.record.refAggreNum);
                conDetailForm.ShowDialog();
            }
            else
            {
                Form conDetailForm = new ContractDetail(history.record.refAggreNum);
                conDetailForm.ShowDialog();
            }
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            purchaseController.GetDocs(history.record.pid);
        }
    }
}
