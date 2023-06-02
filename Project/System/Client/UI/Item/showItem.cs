using Client.Controller;
using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    item.CategoryID);
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
    }
}
