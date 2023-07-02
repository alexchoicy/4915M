using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
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
namespace Client.UI.NHS2

{
    public partial class CreateOrder : Form
    {
        private readonly string _mysqlCon;

        public CreateOrder()
        {
            InitializeComponent();
            _mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(_mysqlCon))
            {
                try
                {
                    connection.Open();

                    // Fetch data for all orders with only the required columns
                    string selectQuery = "SELECT ItemID, MappingID as itemName, Quantity, ResturantID, DeliverAddress FROM `Order` WHERE orderID = LAST_INSERT_ID()";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind DataTable to DataGridView
                    DetailsofGood.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error fetching data from the database: " + ex.Message);
                }
            }
        }

        private int GetNextOrderID()
        {
            int nextOrderID = 1;

            using (MySqlConnection connection = new MySqlConnection(_mysqlCon))
            {
                try
                {
                    connection.Open();

                    string maxOrderIDQuery = "SELECT MAX(orderID) FROM `Order`";
                    MySqlCommand command = new MySqlCommand(maxOrderIDQuery, connection);

                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        nextOrderID = Convert.ToInt32(result) + 1;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error getting next order ID: " + ex.Message);
                }
            }
            return nextOrderID;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            int orderID = GetNextOrderID();
            // Get input values from TextBox controls
            string itemID = ItemIDtxt.Text;
            string itemName = ItemNametxt.Text;
            string quantity = Quantitytxt.Text;
            string deliveryDate = DateTime.Now.ToString("yyyy-MM-dd");
            string deliveryTime = DateTime.Now.ToString("HH:mm:ss");
            string managerID = ManagerIDtxt.Text;
            string ResturantID = ResturantIDtxt.Text;
            string DeliverAddress = DeliverAddresstxt.Text;
            string Status = Statustxt.Text;
            string Urgent = Urgenttxt.Text;

            // Insert data into the database
            using (MySqlConnection connection = new MySqlConnection(_mysqlCon))
            {
                try
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO `Order` (orderID, MappingID, ItemID, ResturantID, Quantity, Urgent, Status, Date, Time) " +
                                         "VALUES (@orderID, @MappingID, @ItemID, @ResturantID, @Quantity, @Urgent, @Status, @Date, @Time)";

                    MySqlCommand command = new MySqlCommand(insertQuery, connection);
                    command.Parameters.AddWithValue("@orderID", orderID);
                    command.Parameters.AddWithValue("@MappingID", itemName);
                    command.Parameters.AddWithValue("@ResturantID", quantity);
                    command.Parameters.AddWithValue("@Quantity", deliveryDate);
                    command.Parameters.AddWithValue("@Urgent", deliveryDate);
                    command.Parameters.AddWithValue("@Status", deliveryDate);
                    command.Parameters.AddWithValue("@Date", deliveryDate);
                    command.Parameters.AddWithValue("@Time", deliveryTime);

                    command.ExecuteNonQuery();

                    LoadData();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
            }
        }
    }
}