using Client.Controller;
using Client.Model.Receive;
using Client.Model.Submit;
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
        private List<ItemModel> data;
        private ItemController ItemController = new ItemController();
        private CreateContract parentForm;

        public AddContractItem(CreateContract parent)
        {
            InitializeComponent();
            LoadData();
            parentForm = parent;
        }

        public AddContractItem(CreateContract parent, List<ContractSumbitItemShowModel> data)
        {
            InitializeComponent();
            LoadData();
            parentForm = parent;
            BindContractItem(data);
        }

        public async void LoadData() {
       
            acItemTxt.TextChanged += acItemTxt_TextChanged;
            data = await ItemController.getAll();
            if (data == null)
            {
                MessageBox.Show("NoData");
                return;
            }
            BindItemDataView(data);
        }

        public void BindItemDataView(List<ItemModel> items)
        {
            itemDataGridView.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemDataGridView,
                    item.itemId,
                    item.name);
                itemDataGridView.Rows.Add(row);
            }
        }

        public void BindContractItem(List<ContractSumbitItemShowModel> data)
        {
            foreach (var items in data)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(acAddItemViewGrid,
                    items.itemID,
                    items.itemName,
                    items.quantity);
                acAddItemViewGrid.Rows.Add(row);
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
                var existingItemId = row.Cells["ItemID"].Value;
                if (existingItemId == null)
                {
                    break;
                }
                if (existingItemId.ToString() == itemID)
                {
                    name = row.Cells["itemName"].Value.ToString();
                    itemExists = true;
                    break;
                }
            }
            if (!itemExists)
            {
                MessageBox.Show("No such items");
                return;
            }
            bool AdditemExists = false;
            foreach (DataGridViewRow row in acAddItemViewGrid.Rows)
            {
                var existingItemId = row.Cells["addItemID"].Value;
                if (existingItemId == null)
                {
                    break;
                }
                if (existingItemId.ToString() == itemID)
                {
                    AdditemExists = true;
                    break;
                }
            }
            if (AdditemExists)
            {
                MessageBox.Show("Item already exists in the grid.");
                return;
            }

            int qty;
            if (!int.TryParse(acQtyTxt.Text, out qty))
            {
                MessageBox.Show("please input number");
                return;
            }
            if (qty < 0)
            {
                MessageBox.Show("qty need > 0");
                return;
            }
            acAddItemViewGrid.Rows.Add(acItemTxt.Text, name, qty);
        }

        private void acAddItemViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            acAddItemViewGrid.Rows.RemoveAt(e.RowIndex);
        }

        private void acSubmitBtn_Click(object sender, EventArgs e)
        {
            List<ContractSumbitItemShowModel> data = new List<ContractSumbitItemShowModel>();

            foreach (DataGridViewRow row in acAddItemViewGrid.Rows)
            {
                var itemIDCell = row.Cells["addItemID"];
                var itemNameCell = row.Cells["AddItemName"];
                var quantityCell = row.Cells["addqty"];

                if (itemIDCell.Value != null && itemNameCell.Value != null && quantityCell.Value != null)
                {
                    var itemID = itemIDCell.Value.ToString();
                    var itemName = itemNameCell.Value.ToString();
                    var quantity = int.Parse(quantityCell.Value.ToString());
                        var sumbitData = new ContractSumbitItemShowModel
                        {
                            itemID = itemID,
                            itemName = itemName,
                            quantity = quantity
                        };
                        data.Add(sumbitData);
                }
            }

            parentForm.ReceiveDataFromAddControlItem(data);
            this.Close();
        }

        private void acItemTxt_TextChanged(object sender, EventArgs e)
        {
            string serachText = acItemTxt.Text.Trim().ToLower();
            List<ItemModel> filterItem = data
                .Where(item =>
                    item.VirtualID.ToLower().Contains(serachText) ||
                    item.itemId.ToLower().Contains(serachText))
                .ToList();
            BindItemDataView(filterItem);
        }
    }
}
