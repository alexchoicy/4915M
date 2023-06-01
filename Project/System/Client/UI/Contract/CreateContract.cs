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
using Client.Model.Submit;

namespace Client.UI.Contract
{
    public partial class CreateContract : Form
    {
        private string filePath;
        private ContractController contractController = new ContractController();
        private List<ContractSumbitItemShowModel> ListItem;
        public CreateContract()
        {
            InitializeComponent();
            ccDropType.SelectedIndex = 1;
        }

        private async void subBtn_Click(object sender, EventArgs e)
        {
            DateTime signDate = DateTime.ParseExact(signTimePick.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime expDate = DateTime.ParseExact(expireTimePick.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int repeatDate;
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
            var staffID = string.IsNullOrEmpty(staffTxt.Text)? GlobalData.UserInfo.StaffID : staffTxt.Text;
            var supplierID = supplierTxt.Text;
            
            int.TryParse(ccRepDateTxt.Text, out repeatDate);
            var contractType = "";
            switch (ccDropType.SelectedIndex)
            {
                case 0:
                    contractType = "PC";
                    break;
                case 1:
                    contractType = "IC";
                    break;
            }

            var data = new ContractDataModel
            {
                ContractID = ContractID,
                SignDate = signDate,
                ExpireTime = expDate,
                ContractType = contractType,
                StaffID = staffID,
                SupplierID = supplierID,
                RepeatDate = repeatDate
            };
            var ContractData = new ContractSumbitModel
            {
                data = data
            };
            if (contractType == "PC")
            {
                if (!int.TryParse(ccRepDateTxt.Text, out repeatDate) && ccRepDateTxt.Text != null)
                {
                    MessageBox.Show("Error Days");
                    return;
                }
                var items = new List<ContractSumbitItemModel>();
                foreach (DataGridViewRow row in supDataView.Rows)
                {
                    var itemIDCell = row.Cells["itemID"];
                    var quantityCell = row.Cells["quantity"];
                    if (itemIDCell.Value != null && quantityCell.Value != null)
                    {
                        var itemID = itemIDCell.Value.ToString();
                        var quantity = int.Parse(quantityCell.Value.ToString());
                        var sumbitData = new ContractSumbitItemModel
                        {
                            itemID = itemID,
                            quantity = quantity
                        };
                        items.Add(sumbitData);
                    }
                }
                ContractData.ContractItems = items;
            }

            string jsonString = JsonSerializer.Serialize(ContractData);
            var status = await contractController.CreateNewContract(jsonString, filePath);
            if (status)
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
                ccRepDateTxt.Enabled = true;
            }
            if (ccDropType.SelectedIndex == 1)
            {
                ccAddBtn.Enabled = false;
                ccRepDateTxt.Enabled = false;
            }
        }

        private void ccAddBtn_Click(object sender, EventArgs e)
        {
            Form addconform;
            if (ListItem == null)
            {
                addconform = new AddContractItem(this);
            }
            else
            {
                addconform = new AddContractItem(this, ListItem);
            }

            addconform.ShowDialog();
        }

        public void ReceiveDataFromAddControlItem(List<ContractSumbitItemShowModel> data)
        {
            supDataView.Rows.Clear();
            if (data == null)
            {
                Console.WriteLine("No items");
                return;
            }
            foreach (var item in data)
            {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(supDataView,
                        item.itemID,
                        item.itemName,
                        item.quantity
                    );
                    supDataView.Rows.Add(row);
            }

            ListItem = data;
        }

    }
}
