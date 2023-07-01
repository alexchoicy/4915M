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
using Client.Model.Receive;
using Client.Model.Submit;

namespace Client.UI.Order
{
    public partial class OrderDetail : Form
    {
        private OrderController orderController = new OrderController();
        private OrderModel rawOrder;
        private OrderModelWithItems order;

        public OrderDetail(OrderModel order)
        {
            InitializeComponent();
            rawOrder = order;
            Initialize(order.MapLocked);
            getData();
        }

        public async void getData()
        {
            order = await orderController.getDetail(rawOrder.OrderID);
            if (order == null)
            {
                MessageBox.Show("Error");
                return;
            }
            BindData();
        }

        public void BindData()
        {
            orderIDTxt.Text = order.OrderID;
            statusTxt.Text = order.status;
            dateTxt.Text = order.CreatedDate.ToString("d");
            timeTxt.Text = order.CreateTime.ToString();
            emCheck.Checked = order.emergency;
            remarkTxt.Text = order.remark;
            orderDGV.Rows.Clear();
            BindDGV(order.OrderItems);
        }

        public void BindDGV(List<OrderModelWithItemsData> orderItem)
        {
            orderDGV.Rows.Clear();
            foreach (var item in orderItem)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(orderDGV,
                    item.ItemID,
                    item.Name,
                    item.Quantity);
                orderDGV.Rows.Add(row);
            }
        }

        private void Initialize(bool MapLock)
        {
            if (!MapLock)
            {
                emCheck.Enabled = true;
                remarkTxt.ReadOnly = false;
                ItemqtyDGV.ReadOnly = false;
                subBtn.Visible = true;
                canBtn.Visible = true;
                rmBtn.Visible = true;
                editBtn.Visible = true;

            }
        }

        private void canBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void mrBtn_Click(object sender, EventArgs e)
        {
            string message = await orderController.removeOrder(order.OrderID);
            MessageBox.Show(message);
            this.Close();
        }

        private async void subBtn_Click(object sender, EventArgs e)
        {
            if (order.OrderItems == null)
            {
                MessageBox.Show("Error");
                return;
            }
            OrderSubmitModel orderModel = new OrderSubmitModel
            {
                date = order.CreatedDate,
                time = order.CreateTime,
                emergency = emCheck.Checked,
                remark = remarkTxt.Text,
                OrderId = order.OrderID,
                RestaurantID = GlobalData.UserInfo.RestaurantID
            };
            orderModel.OrderItems = new List<OrderItemModel>();

            foreach (var items in order.OrderItems)
            {
                OrderItemModel model = new OrderItemModel
                {
                    ItemID = items.ItemID,
                    Quantity = items.Quantity,
                };
                orderModel.OrderItems.Add(model);
            }

            string jsonString = JsonSerializer.Serialize(orderModel);
            var status = await orderController.editOrder(jsonString,order.OrderID);
            if (status)
            {
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            Form editForm = new EditItem(this, order.OrderItems);
            editForm.ShowDialog();
        }

        public void NewOrderItem(List<OrderModelWithItemsData> orderItem)
        {
            BindDGV(orderItem);
            order.OrderItems = orderItem;
        }
    }
}
