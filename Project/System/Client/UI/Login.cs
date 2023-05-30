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

namespace Client.UI
{
    public partial class Login : Form
    {
        private LoginController loginController = new LoginController();

        public Login()
        {
            InitializeComponent();
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            var result = await loginController.Login(userIDtxt.Text, pwTxt.Text);
            if (result)
            {
                DialogResult = DialogResult.OK; // Set the DialogResult of the Login form
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }


        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
