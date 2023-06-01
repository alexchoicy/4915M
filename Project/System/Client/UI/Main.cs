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

namespace Client.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            var loginForm = new LoginSystem();
            DialogResult result = loginForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitializeComponent();
            }
            else
            {
                this.Close();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            userName.Text = GlobalData.UserInfo.Name.ToString();
        }

        private void ShowContract_Click(object sender, EventArgs e)
        {
            var contractForm = new ShowContract(this);
            this.Hide();
            contractForm.ShowDialog();
        }
    }
}
