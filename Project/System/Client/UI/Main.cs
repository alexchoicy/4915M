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
using Client.Helper;
using Client.Model.Receive;
using Client.UI.Agreement;
using Client.UI.Item;
using Client.UI.Purchase;
using test;

namespace Client.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            if (GlobalData.UserInfo.Department == "Restaurant")
            {
                showContractBtn.Hide();
                showPurBtn.Hide();
            }
            message();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userLabel.Text = GlobalData.UserInfo.Name.ToString();
            idLabel.Text = GlobalData.UserInfo.StaffID;
            deptLabel.Text = GlobalData.UserInfo.Department;
            posLabel.Text = GlobalData.UserInfo.Position;

        }
        public async void message()
        {
            List<MessageModel> message = new List<MessageModel>();
            InvController invController = new InvController();
            message = await invController.messages();
            if (message == null)
            {
                return;
            }
            messageGrid.Rows.Clear();
            foreach (MessageModel messageModel in message)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(messageGrid,
                    messageModel.messages);
                messageGrid.Rows.Add(row);
            }
        }
        private void ShowContract_Click(object sender, EventArgs e)
        {
            var contractForm = new ShowContract(this);
            this.Hide(); 
            contractForm.ShowDialog();
        }

        private void ItemControlBtn_Click(object sender, EventArgs e)
        {
            var itemForm = new showItem(this);
            this.Hide();
            itemForm.ShowDialog();
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void restBtn_Click(object sender, EventArgs e)
        {
            var restForm = new RestaurantManager(this);
            restForm.ShowDialog();
        }

        private void showPurBtn_Click(object sender, EventArgs e)
        {
            var purForm = new ViewPurchase(this);
            purForm.ShowDialog();
        }
    }
}
