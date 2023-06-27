using Client.Controller;
using Client.Model.Receive;
using Client.UI.Contract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.UI.Item.Category;
using Client.Helper;

namespace Client.UI.Item
{
    public partial class showItem : Form
    {
        private List<ItemModel> data;
        private ItemController ItemController = new ItemController();
        private Main mainForm;

        public showItem(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
            siCateBox.Items.Add("All");
            siCateBox.SelectedIndex = 0;
            LoadData();
            siCateBox.SelectedIndexChanged += siCateBox_SelectedIndexChanged;
            siSearchBox.TextChanged += siSearchBox_TextChanged;
            if (GlobalData.UserInfo.Department == "Restaurant")
            {
                siCateBox.Hide();
                siCreateBtn.Hide();
                openCateBtn.Hide();
            }
        }

        private async void LoadData()
        {
            data = await ItemController.getAll();
            if (data == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindItemData(data);
            //setup autoSuggestion in search
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (ItemModel item in data)
            {
                ac.Add(item.VirtualID);
                ac.Add(item.name);
                ac.Add(item.itemId);
            }
            siSearchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            siSearchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            siSearchBox.AutoCompleteCustomSource = ac;

        }

        private void BindItemData(List<ItemModel> data)
        {
            ItemDataGridView.Rows.Clear();
            foreach (var item in data)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(ItemDataGridView,
                    item.itemId,
                    item.SupplierID,
                    item.name,
                    item.quantity,
                    item.UOM,
                    item.CategoryID,
                    "Detail");
                //setup category suggestion
                Debug.WriteLine(item.CategoryID);
                ItemDataGridView.Rows.Add(row);
                if(!siCateBox.Items.Contains(item.CategoryID)) {
                    siCateBox.Items.Add(item.CategoryID);
                }
            }
        }

        private void siCateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (siCateBox.SelectedIndex == 0)
            {
                LoadData();
            }
            else
            {
                var dataIndex = siCateBox.SelectedItem.ToString();
                List<ItemModel> filterdata = data
                    .Where(item => item.CategoryID.Contains(dataIndex)).ToList();
                BindItemData(filterdata);
            }
        }

        private void siSearchBox_TextChanged(object sender, EventArgs e)
        {
            string serachText = siSearchBox.Text.Trim().ToLower();
            List<ItemModel> filterItem = data
                .Where(item =>
                    item.VirtualID.ToLower().Contains(serachText) ||
                    item.name.ToLower().Contains(serachText) ||
                    item.itemId.ToLower().Contains(serachText))
                .ToList();
            BindItemData(filterItem);
        }



        private void siCreateBtn_Click(object sender, EventArgs e)
        {
            Form itemCreate = new ItemCreate(data);
            itemCreate.ShowDialog();
            LoadData();
        }




        //back to main screen when close

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ItemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                { 
                    //set the category combobox item
                    List<string> categoryItems = new List<string>();

                    foreach (var item in siCateBox.Items)
                    {
                        string category = item.ToString();
                        categoryItems.Add(category);
                    }

                    //set selected itemID
                    string itemID = ItemDataGridView.Rows[e.RowIndex].Cells["gvitemID"].Value.ToString();
                    ItemModel itemdata = data.Where(item => item.itemId == itemID).FirstOrDefault();
                    Form conDetail = new ItemDetail(itemdata, categoryItems);
                    conDetail.ShowDialog();
                    LoadData();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return;
            }
        }

        private void openCateBtn_Click(object sender, EventArgs e)
        {
            Form showCate = new ShowCate();
            showCate.ShowDialog();
            LoadData();
        }
    }
}
