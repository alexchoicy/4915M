using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UI
{
    public partial class resetPw : Form
    {
        private LoginController loginController = new LoginController();
        public resetPw()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form LoginSystem = new LoginSystem();
            LoginSystem.ShowDialog();

        }

        private void NewPwTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void getIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void reconfirmPw_Click(object sender, EventArgs e)
        {

        }

        private async void SubmitBtn_Click(object sender, EventArgs e)
        {
            var result = await loginController.Login(getIDTxt.Text, NewPwTxt.Text);
            if (result)
            {
                DialogResult = DialogResult.OK; // Set the DialogResult of the Login form
                this.Hide();
                Form LoginSystem = new LoginSystem();
                LoginSystem.ShowDialog();
                MessageBox.Show("Successful");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void reconfirmPwTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
