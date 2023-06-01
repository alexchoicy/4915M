using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Helper;

namespace Client.UI.Contract
{
    public partial class CreateContract : Form
    {
        private string filePath;
        private ContractController contractController = new ContractController();
        public CreateContract()
        {
            InitializeComponent();
            ccDropType.SelectedIndex = 1;
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            DateTime signDate = DateTime.ParseExact(signTimePick.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime expDate = DateTime.ParseExact(expireTimePick.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (signDate == expDate || expDate < DateTime.Now.Date)
            {
                MessageBox.Show("The Date is incorrect");
                return;
            }

            if (uploadTxt.Text == "")
            {
                MessageBox.Show("Please Upload a Docs");
                return;
            }

            var ContractID = contractTxt.Text;
            var staffID = staffTxt.Text == null ? GlobalData.UserInfo.StaffID : staffTxt.Text;

            var supplierID = supplierTxt.Text;

            var jsonData = new
            {
                ContractID = ContractID,
                SignDate = signDate,
                ExpireTime = expDate,
                ContractType = "",
                StaffID = staffID,
                SupplierID = supplierID,
            };
            string jsonString = JsonSerializer.Serialize(jsonData);

            var status = contractController.CreateNewContract(jsonString, filePath);
            status.Wait();
            bool result = status.Result;
            //var status = true;
            if (result)
            {
                MessageBox.Show("Success");
                DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = fileDialog.FileName;
                uploadTxt.Text = Path.GetFileName(filePath);
            }
        }

        private void ccDropType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ccDropType.SelectedIndex == 0)
            {
                ccAddBtn.Enabled = true;
                ccRmBtn.Enabled = true;
            }
            if (ccDropType.SelectedIndex == 1)
            {
                ccAddBtn.Enabled = false;
                ccRmBtn.Enabled = false;
            }
        }

        private void ccAddBtn_Click(object sender, EventArgs e)
        {
            Form addconform = new AddContractItem();
            addconform.ShowDialog();
            this.Hide();
        }
    }
}
