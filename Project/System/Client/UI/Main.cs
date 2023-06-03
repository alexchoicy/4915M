using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Helper;
using Client.UI.Agreement;
using Client.UI.Item;

namespace Client.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userLabel.Text = GlobalData.UserInfo.Name.ToString();
            idLabel.Text = GlobalData.UserInfo.StaffID;
            deptLabel.Text = GlobalData.UserInfo.Department;
            posLabel.Text = GlobalData.UserInfo.Position;

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
    }
}
