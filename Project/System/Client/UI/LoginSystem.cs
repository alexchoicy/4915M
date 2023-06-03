using Client.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Client.UI
{
    public partial class LoginSystem : Form
    {
        private LoginController loginController = new LoginController();
        public LoginSystem()
        {
            InitializeComponent();
        }

        private void We_Click(object sender, EventArgs e)
        {

        }

        private void resetPwBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form resetPw = new resetPw();
            resetPw.ShowDialog();
            var loginForm = new LoginSystem();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(getIdTxt.Text) || string.IsNullOrEmpty(getPwTxt.Text))
            {
                MessageBox.Show("Please input user Data");
                return;
            };
            var result = await loginController.Login(getIdTxt.Text,getPwTxt.Text);
            Debug.WriteLine(result);
            if (result == "Ok")
            {
                DialogResult = DialogResult.OK; // Set the DialogResult of the Login form
                this.Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void getPwTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void getIDTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginSystem_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
