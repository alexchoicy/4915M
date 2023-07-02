using Client.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Client.UI.NHS2
{
    public partial class RestaurantManager : Form
    {
        private readonly string _mysqlCon;
        private DataGridView DataGridView1;
        private Main mainForm;
        public RestaurantManager(Main mainForm)
        {
            InitializeComponent();
            _mysqlCon = "server=127.0.0.1; user=root; database=project; password=";

            // Initialize the DataGridView control
            DataGridView = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };
            this.Controls.Add(DataGridView);

            // Add the event handler for CellContentClick
            DataGridView.CellContentClick += Datagridview_CellContentClick;

            // Load the data in the DataGridView
            LoadDataInDataGridView();
        }

        private void CreateOrderbtn_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            createOrder.Show();
        }

        private void Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == DataGridView.Columns["EditButtonColumn"].Index)
            {
                int orderID = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["orderID"].Value);
                EditOrder editOrder = new EditOrder(orderID);
                editOrder.Show();
            }
        }

        private void EditOrderbtn_Click(object sender, EventArgs e)
        {
            if (DataGridView.CurrentRow != null)
            {
                int orderID = Convert.ToInt32(DataGridView.CurrentRow.Cells["orderID"].Value);
                EditOrder editOrder = new EditOrder(orderID);
                editOrder.Show();
            }
        }
        private void LoadDataInDataGridView()
        {
            string connectionString = _mysqlCon;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Fetch data for all orders with only the required columns
                string selectQuery = "SELECT orderID, DeliverID, orderDate, DeliverAddress, Status FROM your_table_name";
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);

                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Set DataGridView DataSource
                DataGridView.DataSource = dataTable;
            }
        }
    }
}