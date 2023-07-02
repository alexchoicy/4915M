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
    public partial class EditOrder : Form
    {
        private readonly string _mysqlCon;
        private int _orderID;

        public EditOrder(int orderID)
        {
            InitializeComponent();
            _mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            _orderID = orderID;
            LoadOrderData();
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

        private void Edit_Click(object sender, EventArgs e)
        {

            int orderID = GetNextOrderID();
            // Get input values from TextBox controls
            string itemID = ItemIDtxt.Text;
            string itemName = ItemNametxt.Text;
            string quantity = Quantitytxt.Text;
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

                    // Replace your_table_name with the actual table name
                    string UpdateQuery = "UPDATE `Order` SET  MappingID = @MappingID, `ResturantID` = @ResturantID, `Quantity` = @Quantity, `Urgent` = @Urgent, `Status` = @Status, `Date` = @Date, `Time` = @Time WHERE `ItemID` = @ItemID";

                    MySqlCommand command = new MySqlCommand(UpdateQuery, connection);
                    command.Parameters.AddWithValue("@orderID", orderID);
                    command.Parameters.AddWithValue("@MappingID", itemName);
                    command.Parameters.AddWithValue("@ItemID", itemID);
                    command.Parameters.AddWithValue("@ResturantID", quantity);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@Urgent", Urgent);
                    command.Parameters.AddWithValue("@Status", Status);

                    command.ExecuteNonQuery();

                    // Fetch data for the newly inserted order
                    string selectQuery = "SELECT orderID, MappingID, ItemID, ResturantID, Quantity, Urgent, Status, Date, Time FROM `Order` WHERE orderID = LAST_INSERT_ID()";
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@orderID", orderID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind DataTable to DataGridView
                    DetailsofGood.DataSource = dt;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
            }
        }
        private void LoadOrderData()
        {
            using (MySqlConnection connection = new MySqlConnection(_mysqlCon))
            {
                try
                {
                    connection.Open();

                    // Replace your_table_name with the actual table name
                    string selectQuery = "SELECT ItemID, MappingID, ResturantID, Quantity, Urgent, Status, Date, Time FROM `Order` WHERE orderID = @orderID";

                    MySqlCommand command = new MySqlCommand(selectQuery, connection);
                    command.Parameters.AddWithValue("@orderID", _orderID);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ItemIDtxt.Text = reader["ItemID"].ToString();
                            ItemNametxt.Text = reader["MappingID"].ToString();
                            Quantitytxt.Text = reader["Quantity"].ToString();
                            Urgenttxt.Text = reader["Urgent"].ToString();
                            ManagerIDtxt.Text = reader["Date"].ToString();
                            ResturantIDtxt.Text = reader["ResturantID"].ToString();
                            DeliverAddresstxt.Text = reader["Time"].ToString();
                            Statustxt.Text = reader["Status"].ToString();
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error connecting to the database: " + ex.Message);
                }
            }
        }
    }
}