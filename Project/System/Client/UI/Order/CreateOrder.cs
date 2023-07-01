using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Helper;
using Client.Model.Local;
using Client.Model.Submit;

namespace Client.UI.Order
{
    public partial class CreateOrder : Form
    {
        private List<OrderViewModel> listItem;
        private OrderController orderController = new OrderController();
        private string newOrderID;
        public CreateOrder()
        {
            InitializeComponent();
            getNEwID();
        }

        private async void getNEwID()
        {
            string orderID = await orderController.getnewID();
            newOrderID = orderID;
            if (orderID == null)
            {
                MessageBox.Show("Error");
                return;
            }
            orderIDTxt.Text = orderID;
        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            Form addItem;
            if (listItem == null)
            {
                addItem = new AddItemOrder(this);
            }
            else
            {
                addItem = new AddItemOrder(this, listItem);
            }
            DialogResult addItemForm = addItem.ShowDialog();
        }


        public void itemOrderDGVItemAdd(List<OrderViewModel> data)
        {
            itemOrderDGV.Rows.Clear();
            if (data == null)
            {
                Console.WriteLine("No items");
                return;
            }

            foreach (OrderViewModel item in data)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemOrderDGV,
                    item.ItemID,
                    item.Name,
                    item.Quantity);
                itemOrderDGV.Rows.Add(row);
            }
            listItem = data;
        }

        private async void submitBtn_Click(object sender, EventArgs e)
        {
            if (listItem == null)
            {
                MessageBox.Show("Error");
                return;
            }
            OrderSubmitModel orderModel = new OrderSubmitModel
            {
                date = DateTime.Now.Date,
                time = DateTime.Now.TimeOfDay,
                emergency = EmergencyCheck.Checked,
                remark = remarkTxt.Text,
                OrderId = newOrderID,
                RestaurantID = GlobalData.UserInfo.RestaurantID
            };
            orderModel.OrderItems = new List<OrderItemModel>();

            foreach (OrderViewModel items in listItem)
            {
                OrderItemModel model = new OrderItemModel
                {
                    ItemID = items.ItemID,
                    Quantity = items.Quantity,
                };
                orderModel.OrderItems.Add(model);
            }

            string jsonString = JsonSerializer.Serialize(orderModel);
            var status = await orderController.createOrder(jsonString);
            if (status)
            {
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
