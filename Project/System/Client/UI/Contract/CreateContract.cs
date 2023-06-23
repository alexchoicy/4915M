using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Helper;
using Client.Model.Receive;
using Client.Model.Submit;

namespace Client.UI.Contract
{
    public partial class CreateContract : Form
    {
        private string filePath;
        private ContractController contractController = new ContractController();
        private SupplierController suppliercontroller = new SupplierController();

        private List<ContractSumbitItemShowModel> ListItem;
        private List<SupplierModel> suppliers;
        private List<ContractModel> contracts;

        public CreateContract(List<ContractModel> item)
        {
            contracts = item;
            InitializeComponent();
            ccDropType.SelectedIndex = 1;
            SupplierText();
            StaffLock.CheckedChanged += StaffLock_CheckedChanged;
            setUpComponent();
        }
        public CreateContract()
        {
            InitializeComponent();
            ccDropType.SelectedIndex = 1;
            SupplierText();
            StaffLock.CheckedChanged += StaffLock_CheckedChanged;
            getContractData();
            setUpComponent();
        }

        private void setUpComponent()
        {
            signTimePick.CustomFormat = "dd/MM/yyyy";
            expireTimePick.CustomFormat = "dd/MM/yyyy";
        }


        private async void getContractData()
        {
            contracts = await contractController.getAll();
        }

        private async void SupplierText()
        {
            suppliers = await suppliercontroller.getAll();
            if(suppliers != null)
            {
                AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
                foreach (var item in suppliers)
                {
                    ac.Add(item.SupplierID+ $" ({item.SupName})");
                    ccCBSupID.Items.Add(item.SupplierID + $" ({item.SupName})");
                }
                ccCBSupID.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ccCBSupID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ccCBSupID.AutoCompleteCustomSource = ac;
                
            }
        }
        private async void subBtn_Click(object sender, EventArgs e)
        {
            DateTime signDate = DateTime.ParseExact(signTimePick.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime expDate = DateTime.ParseExact(expireTimePick.Value.ToString("dd/MM/yyyy"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            int repeatDate;
            string refid = refNumTxt.Text;
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
            if (string.IsNullOrEmpty(refid))
            {
                MessageBox.Show("Please Input the ref Number");
                return;
            }
            var ContractID = contractTxt.Text;
            var staffID = string.IsNullOrEmpty(staffTxt.Text)? GlobalData.UserInfo.StaffID : staffTxt.Text;
            String rawsupplierID = ccCBSupID.Text;
            Regex regex = new Regex("\\s");
            string[] supID = regex.Split(rawsupplierID);
            String supplierID = supID[0].Trim();
            MessageBox.Show(supID[0]);
            bool correct = false;

            foreach (var item in suppliers)
            {
                if(supplierID == item.SupplierID)
                {
                    correct = true;
                    break;
                }
            }

            if (!correct)
            {
                MessageBox.Show("Incorrect Supplier ID");
                return;
            }
            int.TryParse(ccRepDateTxt.Text, out repeatDate);
            var contractType = "";
            switch (ccDropType.SelectedIndex)
            {
                case 0:
                    contractType = "PC";
                    break;
                case 1:
                    contractType = "BPA";
                    break;
                case 2:
                    contractType = "Contract";
                    break;
            }
            var data = new ContractDataModel
            {
                ContractID = contractType + ContractID,
                SignDate = signDate,
                ExpireTime = expDate,
                ContractType = contractType,
                StaffID = staffID,
                SupplierID = supplierID,
                RepeatDate = repeatDate,
                refsupNum = refid
            };
            var ContractData = new ContractSumbitModel
            {
                data = data
            };
            var items = new List<ContractSumbitItemModel>();

            if (contractType == "PC")
            {
                if (!int.TryParse(ccRepDateTxt.Text, out repeatDate) && ccRepDateTxt.Text != null)
                {
                    MessageBox.Show("Error Days");
                    return;
                }               
                foreach (DataGridViewRow row in supDataView.Rows)
                {
                    var itemIDCell = row.Cells["itemID"];
                    var quantityCell = row.Cells["quantity"];
                    var priceCell = row.Cells["priceDataGrid"];
                    if (itemIDCell.Value != null && quantityCell.Value != null && priceCell.Value != null)
                    {
                        var itemID = itemIDCell.Value.ToString();
                        var quantity = int.Parse(quantityCell.Value.ToString());
                        var price = double.Parse(priceCell.Value.ToString());
                        var sumbitData = new ContractSumbitItemModel
                        {
                            itemID = itemID,
                            quantity = quantity,
                            price = price
                        };
                        items.Add(sumbitData);
                    }
                }
                ContractData.ContractItems = items;
            }else if(contractType == "BPA"){
                foreach (DataGridViewRow row in supDataView.Rows)
                {
                    var itemIDCell = row.Cells["itemID"];
                    var priceCell = row.Cells["priceDataGrid"];
                    var quantityCell = row.Cells["moqData"];
                    if (itemIDCell.Value != null && quantityCell.Value != null && priceCell.Value != null)
                    {
                        var itemID = itemIDCell.Value.ToString();
                        var quantity = double.Parse(quantityCell.Value.ToString());
                        var price = double.Parse(priceCell.Value.ToString());
                        var sumbitData = new ContractSumbitItemModel
                        {
                            itemID = itemID,
                            MOQ = quantity,
                            price = price
                        };
                        items.Add(sumbitData);
                    }
                }
                ContractData.ContractItems = items;
            }else if (contractType == "Contract")
            {

            }

            string jsonString = JsonSerializer.Serialize(ContractData);
            Console.WriteLine(jsonString);
            var status = await contractController.CreateNewContract(jsonString, filePath, ContractID);
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
            if (ccDropType.SelectedIndex == 0)
            {
                ccAddBtn.Enabled = true;
                ccRepDateTxt.Enabled = true;
            }
            else if (ccDropType.SelectedIndex == 1)
            {
                ccAddBtn.Enabled = true;
                ccRepDateTxt.Enabled = false;
            }
            else if (ccDropType.SelectedIndex == 2)
            {
                ccAddBtn.Enabled = false;
                ccRepDateTxt.Enabled = false;
            }
        }

        private void ccAddBtn_Click(object sender, EventArgs e)
        {
            string rawsupplierID = ccCBSupID.Text;
            Regex regex = new Regex("\\s");
            string[] supID = regex.Split(rawsupplierID);
            string supplierID = supID[0].Trim();

            if (string.IsNullOrEmpty(supplierID))
            {
                MessageBox.Show("Please Select a supplier first");
                return;
            }
            if(ccDropType.SelectedIndex == 0)
            {
                Form addconform;
                if (ListItem == null)
                {
                    addconform = new AddContractItem(this, supplierID);
                }
                else
                {
                    addconform = new AddContractItem(this, ListItem, supplierID);
                }
                DialogResult addConFrom = addconform.ShowDialog();
                if(addConFrom == DialogResult.OK)
                {
                    ccDropType.Enabled = false;
                }
            }
            else
            {
                Form addBpaFrom; ;
                if (ListItem == null)
                {
                    addBpaFrom = new AddBPAitem(this, supplierID);
                }
                else
                {
                    addBpaFrom = new AddBPAitem(this, ListItem, supplierID);
                }
                DialogResult bpaForm = addBpaFrom.ShowDialog();
                if (bpaForm == DialogResult.OK)
                {
                    ccDropType.Enabled = false;
                }
            }
        }

        public void ReceiveDataFromAddControlItem(List<ContractSumbitItemShowModel> data)
        {
            supDataView.Rows.Clear();
            if (data == null)
            {
                Console.WriteLine("No items");
                return;
            }
            if(ccDropType.SelectedIndex == 0)
            {
                supDataView.Columns["moqData"].Visible = false;
                supDataView.Columns["quantity"].Visible = true;
                foreach (var item in data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(supDataView,
                        item.itemID,
                        item.itemName,
                        item.quantity,
                        item.price
                    );
                    supDataView.Rows.Add(row);
                }

                ListItem = data;
            }
            else if(ccDropType.SelectedIndex == 1)
            {
                supDataView.Columns["moqData"].Visible = true;
                supDataView.Columns["quantity"].Visible = false;
                foreach (var item in data)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(supDataView,
                        item.itemID,
                        item.itemName,
                        "",
                        item.price,
                        item.MOQ
                    );
                    supDataView.Rows.Add(row);
                }

                ListItem = data;
            }
        }

        private void AutoCreateItemID(string supID)
        {
            int biggest = -1;
            foreach (var item in contracts.Where(item => item.SupplierID == supID))
            {
                int id = int.Parse(item.ContractID.Substring(supID.Length));
                if (id > biggest)
                {
                    biggest = id;
                    Debug.WriteLine(biggest + " " + id);
                }
            }
            if (biggest == -1)
            {
                biggest = 0;
            }

            int nextID = biggest + 1;
            string newItemID = supID + nextID.ToString().PadLeft(3, '0');
            contractTxt.Text = newItemID;
        }




        private void StaffLock_CheckedChanged(object sender, EventArgs e)
        {
            if (StaffLock.Checked)
            {
                staffTxt.ReadOnly = false;
            }
            else
            {
                staffTxt.ReadOnly = true;
            }
        }

        private void ccCBSupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            String rawsupplierID = ccCBSupID.Text;
            Regex regex = new Regex("\\s");
            string[] regexData = regex.Split(rawsupplierID);
            string supID = regexData[0].Trim();
            bool subcheck = false;
            foreach (var item in suppliers)
            {
                if (supID == item.SupplierID)
                {
                    subcheck = true;
                    break;
                }
            }
            if (!subcheck)
            {
                MessageBox.Show("Incorrect Supplier ID");
                return;
            }
            AutoCreateItemID(supID);
        }
    }
}
