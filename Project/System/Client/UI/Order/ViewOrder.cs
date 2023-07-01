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
using Client.Controller;
using Client.Model.Receive;

namespace Client.UI.Order
{
    public partial class ViewOrder : Form
    {
        private OrderController orderController = new OrderController();
        private List<OrderModel> orderList;
        public ViewOrder()
        {
            InitializeComponent();
            GetData();
        }

        private async void GetData()
        {
            orderList = await orderController.getOrder();
            if (orderList == null)
            {
                MessageBox.Show("Error");
                return;
            }
            BindData(orderList);
        }
        private void BindData(List<OrderModel> items)
        {
            orderDGV.Rows.Clear();
            foreach (var order in items)
            {
                
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(orderDGV,
                    order.MapLocked,
                    order.OrderID,
                    getSatus(order.status),
                    order.CreatedDate.ToString("d"),
                    order.CreateTime.ToString("c"),
                    order.emergency,
                    "");
                orderDGV.Rows.Add(row);
            }
        }

        private string getSatus(string rawstatus)
        {
            string st = "";
            switch (rawstatus)
            {
                case "P":
                    st = "Pending";
                    break;
                case "F":
                    st = "Finish";
                    break;
            }

            return st;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form createOrder = new CreateOrder();
            createOrder.ShowDialog();
            GetData();
        }

        private void orderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 6)
                {
                    string orderID = orderDGV.Rows[e.RowIndex].Cells["orderidDGV"].Value.ToString();
                    OrderModel selectOrder = orderList.Where(item => item.OrderID == orderID).FirstOrDefault();
                    Debug.WriteLine(selectOrder.ToString());
                    Form orderDetail = new OrderDetail(selectOrder);
                    orderDetail.ShowDialog();
                    GetData();
                }
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception);
                throw;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string serachText = textBox1.Text.Trim().ToLower();
            List<OrderModel> filterItem = orderList
                .Where(item =>
                    item.OrderID.ToLower().Contains(serachText))
                .ToList();
            BindData(filterItem);
        }
    }
}
