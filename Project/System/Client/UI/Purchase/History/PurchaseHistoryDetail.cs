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
            cdcontractIdTxt.Text = history.record.ContractID;
            SupIDTxt.Text = history.record.supID;
            supRefTxt.Text = history.record.refAggreNum;
            typeTxt.Text = history.record.Type;
            dateTxt.Text = history.record.date.ToString("d");
            expDatePick.Value = history.record.expDate;
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
                    record.supRefItemID,
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

        private async void upBtn_Click(object sender, EventArgs e)
        {
            if(expDatePick.Value < DateTime.Now)
            {
                MessageBox.Show("Exp Date Error");
                return;
            }
            ExpDateUpdate expDate = new ExpDateUpdate
            {
                pid = history.record.pid,
                expDate = expDatePick.Value,
            };
            await purchaseController.updateExp(expDate);
        }
    }
}
