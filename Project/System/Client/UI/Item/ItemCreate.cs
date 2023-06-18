using Client.Controller;
using Client.Model.Receive;
using Client.Model.Submit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UI.Contract;
using Client.UI.Item.Category;

namespace Client.UI.Item
{
    public partial class ItemCreate : Form
    {
        private ContractController contractController = new ContractController();
        private SupplierController suppliercontroller = new SupplierController();
        private ItemController itemcontroller = new ItemController();
        private CategoryController categoryController = new CategoryController();
        private List<SupplierModel> suppliersData;
        private List<ContractIDDto> contractData;
        private List<ItemModel> itemData;

        public ItemCreate(List<ItemModel> data)
        {
            itemData = data;
            InitializeComponent();
            getStartData();
            SupIDTxt.SelectedIndexChanged += SupIDTxt_SelectedIndexChanged;
        }
        public ItemCreate()
        {
            InitializeComponent();
            getItemData();
            getStartData();
            SupIDTxt.SelectedIndexChanged += SupIDTxt_SelectedIndexChanged;
        }

        private async void getItemData()
        {
            itemData = await itemcontroller.getAll();
        }

        private async void getStartData()
        {

            //setup suggestion of supplierID

            suppliersData = await suppliercontroller.getAll();
            if (suppliersData != null)
            {
                SupIDTxt.Items.Clear();
                AutoCompleteStringCollection acSup = new AutoCompleteStringCollection();
                foreach (var item in suppliersData)
                {
                    acSup.Add(item.SupplierID + $" ({item.SupName})");
                    SupIDTxt.Items.Add(item.SupplierID + $" ({item.SupName})");
                }
                SupIDTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                SupIDTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                SupIDTxt.AutoCompleteCustomSource = acSup;
            }

            //setup suggestion of Virtual ID

            AutoCompleteStringCollection acVID = new AutoCompleteStringCollection();
            virtIDTxt.Items.Clear();
            foreach (var item in itemData)
            {
                
                if (!acVID.Contains(item.VirtualID))
                {
                    acVID.Add(item.VirtualID);
                    virtIDTxt.Items.Add(item.VirtualID);
                }
            }
            virtIDTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            virtIDTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            virtIDTxt.AutoCompleteCustomSource = acVID;

            //setup suggestion of Category ID
            var cateData =await categoryController.getAll();
            AutoCompleteStringCollection acCate = new AutoCompleteStringCollection();
            cateIDTxt.Items.Clear();
            foreach (var item in cateData)
            {
                if (!acCate.Contains(item.CategoryID))
                {
                    acCate.Add(item.CategoryID);
                    cateIDTxt.Items.Add(item.CategoryID + $" {item.name}");
                }
            }
            cateIDTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cateIDTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cateIDTxt.AutoCompleteCustomSource = acCate;


        }

        private async void getContractBysup(string id)
        {
        }
        private void SupIDTxt_SelectedIndexChanged(object sender, EventArgs e)
        {
            String rawsupplierID = SupIDTxt.Text;
            Regex regex = new Regex("\\s");
            string[] regexData = regex.Split(rawsupplierID);
            string supID = regexData[0].Trim();
            bool subcheck = false;
            foreach (var item in suppliersData)
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

            getContractBysup(supID);
            AutoCreateItemID(supID);
        }

        private void AutoCreateItemID(string supID)
        {
            int biggest = -1;
            foreach (var item in itemData.Where(item => item.SupplierID == supID))
            {
                int id = int.Parse(item.itemId.Substring(supID.Length));
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
            string newItemID = supID + nextID.ToString().PadLeft(3,'0');
            itemIDTxt.Text = newItemID;
        }

        private async void sumBtn_Click(object sender, EventArgs e)
        {
            string itemID = itemIDTxt.Text;
            string rawSupplierID = SupIDTxt.Text;
            string itemname = itemNameTxt.Text;
            string rawcateID = cateIDTxt.Text;
            // only get ID
            Regex regex = new Regex("\\s");
            string[] supID = regex.Split(rawSupplierID);
            string SupplierID = supID[0].Trim();
            string[] cateID = regex.Split(rawcateID);
            string CategoryID = cateID[0].Trim();




            if (string.IsNullOrEmpty(rawSupplierID) || string.IsNullOrEmpty(rawSupplierID) || string.IsNullOrEmpty(CategoryID) 
               || string.IsNullOrEmpty(itemname) || string.IsNullOrEmpty(CategoryID) || string.IsNullOrEmpty(virtIDTxt.Text))
            {
                MessageBox.Show("Please input all item");
                return;
            }

            int itemprice;
            if (!int.TryParse(itemPriceTxt.Text, out itemprice))
            {
                MessageBox.Show("Incorrect information of Price");
                return;
            }
            List<ItemCreateModel> itemDatas = new List<ItemCreateModel>();
            ItemCreateModel itemData = new ItemCreateModel
            {
                itemId = itemID,
                SupplierID = SupplierID,
                name = itemname,
                CategoryID = CategoryID,
                price = itemprice,
                VirtualID = virtIDTxt.Text
            };
            itemDatas.Add(itemData);

            var status = await itemcontroller.CreateNewItem(itemDatas);
            if (status)
            {
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            MessageBox.Show("Error");
        }

        private void cnewConBtn_Click(object sender, EventArgs e)
        {
            Form createForm = new CreateContract();
            createForm.ShowDialog();

            getItemData();
            getStartData();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cateBtn_Click(object sender, EventArgs e)
        {
            Form createCate = new CreateCate();
            createCate.ShowDialog();
            getItemData();
            getStartData();
            
        }
    }

}
