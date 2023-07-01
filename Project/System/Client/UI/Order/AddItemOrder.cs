using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model.Local;
using Client.Model.Receive;
using Client.Model.Submit;
using Client.UI.Contract;

namespace Client.UI.Order
{
    public partial class AddItemOrder : Form
    {
        private ItemController itemController = new ItemController();
        private List<ItemModel> data;
        private CreateOrder parentForm;


        public AddItemOrder(CreateOrder form)
        {
            InitializeComponent();
            LoadData();
            setUP(form);
        }

        public AddItemOrder(CreateOrder form,List<OrderViewModel> orderItem)
        {
            InitializeComponent();
            LoadData();
            setUP(form);
            BindOrderItem(orderItem);
        }

        public void setUP(CreateOrder form)
        {
            AddItemViewGrid.CellContentClick += AddItemViewGrid_CellContentClick;
            parentForm = form;
        }

        private async void LoadData()
        {
            data = await itemController.getAll();
            if (data == null)
            {
                MessageBox.Show("No Data");
                return;
            }

            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            foreach (var item in data)
            {
                acItemTxt.Items.Add(item.itemId);
                ac.Add(item.itemId);
            }
            acItemTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
            acItemTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            acItemTxt.AutoCompleteCustomSource = ac;
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

        public void BindOrderItem(List<OrderViewModel> items)
        {
            AddItemViewGrid.Rows.Clear();
            foreach (var item in items)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(AddItemViewGrid,
                    item.ItemID,
                    item.Name,
                    item.Quantity);
                AddItemViewGrid.Rows.Add(row);
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
            foreach (DataGridViewRow row in AddItemViewGrid.Rows)
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
            double qty;
            if (!double.TryParse(acQtyTxt.Text, out qty))
            {
                MessageBox.Show("please input number");
                return;
            }
            if (qty < 0)
            {
                MessageBox.Show("qty need > 0");
                return;
            }

            AddItemViewGrid.Rows.Add(itemID, name, qty);
        }

        private void searchTxt_TextChanged(object sender, EventArgs e)
        {
            string serachText = searchTxt.Text.Trim().ToLower();
            List<ItemModel> filterItem = data
                .Where(item =>
                    item.VirtualID.ToLower().Contains(serachText) ||
                    item.itemId.ToLower().Contains(serachText) ||
                    item.name.ToLower().Contains(serachText))
                .ToList();
            BindItemDataView(filterItem);
        }

        private void AddItemViewGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
                AddItemViewGrid.Rows.RemoveAt(e.RowIndex);
        }

        private void acSubmitBtn_Click(object sender, EventArgs e)
        {
            List<OrderViewModel> items = new List<OrderViewModel>();
            foreach (DataGridViewRow row in AddItemViewGrid.Rows)
            {
                var itemID = row.Cells["addItemID"].Value.ToString();
                var itemQty = double.Parse(row.Cells["addqty"].Value.ToString());
                var itemName = row.Cells["AddItemName"].Value.ToString();

                if (itemID != "" || itemQty != 0 || itemName != "")
                {
                    OrderViewModel item = new OrderViewModel
                    {
                        ItemID = itemID,
                        Name = itemName,
                        Quantity = itemQty
                    };
                    items.Add(item);
                }
            }

            parentForm.itemOrderDGVItemAdd(items);
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void acCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
