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

namespace Client.UI.Contract
{
    public partial class AddContractItem : Form
    {
        private ItemController ItemController = new ItemController();

        public AddContractItem()
        {
            InitializeComponent();
            LoadData();
        }


        public async void LoadData()
        {
            var data = await ItemController.getAll();
            if(data == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindItemDataView(data);
        }

        public void BindItemDataView(List<ItemModel> items)
        {
            foreach(var item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemDataGridView,
                    item.itemId,
                    item.name);
                itemDataGridView.Rows.Add(row);
            }
        }

        private void acAddBtn_Click(object sender, EventArgs e)
        {
            var name = "";
            var itemID = acItemTxt.Text;
            if (acItemTxt.Text == null)
            {
                MessageBox.Show("add itemID");
                return;
            }
            bool itemExists = false;
            foreach (DataGridViewRow row in itemDataGridView.Rows)
            {
                string existingItemId = row.Cells["ItemID"].Value.ToString();
                if (existingItemId == itemID)
                {
                    name = row.Cells["itemName"].Value.ToString();
                    itemExists = true;
                    break;
                }
            }
            bool AdditemExists = false;
            if(itemExists != true)
            {
                MessageBox.Show("No such items");
                return;
            }

            foreach (DataGridViewRow row in acAddItemViewGrid.Rows)
            {
                string existingItemId = row.Cells["ItemID"].Value.ToString();
                if (existingItemId == itemID)
                {
                    itemExists = true;
                    break;
                }
            }
            if (itemExists)
            {
                MessageBox.Show("Item already exists in the grid.");
                return;
            }

            var qty = int.Parse(acQtyTxt.Text);
            if (qty < 0)
            {
                MessageBox.Show("qty need > 0");
                return;
            }
            acAddItemViewGrid.Rows.Add(acItemTxt.Text, name, qty);
        }
    }
}
