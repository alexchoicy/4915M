using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Client.Helper;
using System.Transactions;

namespace Client.UI.NHS2.Mapping
{
    public partial class MapItem : UserControl
    {
        private readonly string connectionString = "server=127.0.0.1; user=root; database=project; password=";
        private string receivedOrderID;
        private string _mappingID;
        public MapItem(string orderID,string mappingID)
        {
            InitializeComponent();
            receivedOrderID = orderID;
            textBox1.Text = receivedOrderID;
            _mappingID = mappingID;
            ConfigureDataGridView();
            LoadDataFromDatabase();
        }

        public MapItem()
        {
        }

        private void LoadDataFromDatabase()
        {
            string query = "SELECT ItemID, Quantity FROM [Order] WHERE OrderID = @orderID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@orderID", receivedOrderID);

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    foreach (DataRow row in dataTable.Rows)
                    {
                        dataGridView1.Rows.Add(row["ItemID"], row["Quantity"], null);
                    }
                }
            }
        }

        private void ConfigureDataGridView()
        {
            DataGridViewTextBoxColumn itemID = new DataGridViewTextBoxColumn
            {
                Name = "itemIDDGV",
                HeaderText = "Item ID",
                ValueType = typeof(int)
            };

            DataGridViewTextBoxColumn quantity = new DataGridViewTextBoxColumn
            {
                Name = "quantityDGV",
                HeaderText = "Quantity",
                ValueType = typeof(int)
            };

            DataGridViewComboBoxColumn options = new DataGridViewComboBoxColumn
            {
                Name = "optionsDGV",
                HeaderText = "Options",
                ValueType = typeof(string)
            };

            options.Items.AddRange("Purchase", "Warehouse", "Contract");

            dataGridView1.Columns.AddRange(itemID, quantity, options);
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                string selectedValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                int itemID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                int quantity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    switch (selectedValue)
                    {
                        case "Purchase":
                            InsertDataIntoPurchaseAndItemTables(connection, itemID, quantity);
                            break;

                        case "Warehouse":
                            InsertDataIntoDeliveryAndDeliveryDetailTables(connection, itemID, quantity);
                            break;

                        case "Contract":
                            InsertDataIntoContractAndItemTables(connection, itemID, quantity);
                            break;
                    }
                }
            }
        }


        private void InsertDataIntoPurchaseAndItemTables(SqlConnection connection, int itemID, int quantity)
        {
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertItemBuyQuery = "INSERT INTO item_buy (buyID, itemID, quantity) VALUES (@buyID, @itemID, @quantity);";

                    string buyID = "1"; // Assuming a constant buyID value

                    using (SqlCommand insertItemBuyCommand = new SqlCommand(insertItemBuyQuery, connection))
                    {
                        insertItemBuyCommand.Parameters.AddWithValue("@buyID", buyID);
                        insertItemBuyCommand.Parameters.AddWithValue("@itemID", itemID);
                        insertItemBuyCommand.Parameters.AddWithValue("@quantity", quantity);

                        insertItemBuyCommand.ExecuteNonQuery();
                    }
                    string insertDelivery = "Insert into Delivery (OrderID, DeliveryID, RestaurantID, deliveryDate, deliveryTime, State, deliveryDetail) VALUES (@OrderID, @DeliveryID, @RestaurantID, @deliveryDate, @deliveryTime, @State, @deliveryDetail)";
                    string insertDeliveryDetail =
                        "INSERT INTO `deliverydetail`(`OrderID`, `DeliveryID`, `ResturantID`, `deliveryDate`, `deliveryTime`, `itemID`, `SupplierssupID`, `itemName`, `State`, `price`, `ResturantName`, `Address`, `itemQuantity`) VALUES" +
                        "@OrderID, @DeliveryID, @ResturantID, @deliveryDate, @deliveryTime, @itemID, @SupplierssupID, @itemName, @State, @price, @ResturantName, @Address, @itemQuantity";
            // Add placeholder values
                    string deliveryID = "D001";
                    DateTime date = DateTime.Now;
                    string state = "Purchase";
                    using (SqlCommand insertDeliveryCommand = new SqlCommand(insertDelivery, connection))
                    {
                        insertDeliveryCommand.Parameters.AddWithValue("@OrderID", receivedOrderID);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryID", deliveryID);
                        insertDeliveryCommand.Parameters.AddWithValue("@RestaurantID", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryDate", date);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryTime", "8:00");
                        insertDeliveryCommand.Parameters.AddWithValue("@State", state);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryDetail", "detail");
                        insertDeliveryCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand insertDeliveryDetailCommand = new SqlCommand(insertDeliveryDetail, connection))
                    {
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@OrderID", receivedOrderID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@DeliveryID", deliveryID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@ResturantID", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@deliveryDate", date);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@deliveryTime", "8:00");
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemID", itemID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@SupplierssupID", "1");
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemName", itemID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@State", state);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@price", 10.0); // Sample price
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@ResturantName", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@Address", GlobalData.UserInfo.address);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemQuantity", quantity);
                        insertDeliveryDetailCommand.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error inserting data into item_buy table: " + ex.Message);
                }
            }
        }


        private void InsertDataIntoDeliveryAndDeliveryDetailTables(SqlConnection connection, int itemID, int quantity)
        {
             // Start a transaction
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertDelivery = "Insert into Delivery (OrderID, DeliveryID, RestaurantID, deliveryDate, deliveryTime, State, deliveryDetail) VALUES (@OrderID, @DeliveryID, @RestaurantID, @deliveryDate, @deliveryTime, @State, @deliveryDetail)";
                    string insertDeliveryDetail =
                        "INSERT INTO `deliverydetail`(`OrderID`, `DeliveryID`, `ResturantID`, `deliveryDate`, `deliveryTime`, `itemID`, `SupplierssupID`, `itemName`, `State`, `price`, `ResturantName`, `Address`, `itemQuantity`) VALUES" +
                        "@OrderID, @DeliveryID, @ResturantID, @deliveryDate, @deliveryTime, @itemID, @SupplierssupID, @itemName, @State, @price, @ResturantName, @Address, @itemQuantity";
                    // Add placeholder values
                    string deliveryID = "D001";
                    DateTime date = DateTime.Now;
                    string state = "Warehouse";
                    using (SqlCommand insertDeliveryCommand = new SqlCommand(insertDelivery, connection))
                    {
                        insertDeliveryCommand.Parameters.AddWithValue("@OrderID", receivedOrderID);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryID", deliveryID);
                        insertDeliveryCommand.Parameters.AddWithValue("@RestaurantID", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryDate", date);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryTime", "8:00");
                        insertDeliveryCommand.Parameters.AddWithValue("@State", state);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryDetail", "detail");
                        insertDeliveryCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand insertDeliveryDetailCommand = new SqlCommand(insertDeliveryDetail, connection))
                    {
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@OrderID", receivedOrderID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@DeliveryID", deliveryID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@ResturantID", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@deliveryDate", date);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@deliveryTime", "8:00");
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemID", itemID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@SupplierssupID", "1");
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemName", itemID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@State", state);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@price", 10.0); // Sample price
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@ResturantName", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@Address", GlobalData.UserInfo.address);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemQuantity", quantity);
                        insertDeliveryDetailCommand.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error inserting data into item_buy table: " + ex.Message);
                }
            }
        }

        private void InsertDataIntoContractAndItemTables(SqlConnection connection, int itemID, int quantity)
        {
            // Assuming you have a Contract table and a ContractItem table
            // Start a transaction
            using (SqlTransaction transaction = connection.BeginTransaction())
            {
                try
                {
                    string insertItemBuyQuery = "INSERT INTO item_buy (buyID, itemID, quantity) VALUES (@buyID, @itemID, @quantity);";
                    using (SqlCommand command = new SqlCommand(insertItemBuyQuery, connection, transaction))
                    {
                        command.Parameters.AddWithValue("@buyID", 1); // Assuming a constant buyID value
                        command.Parameters.AddWithValue("@itemID", itemID);
                        command.Parameters.AddWithValue("@quantity", quantity);

                        command.ExecuteNonQuery();
                    }
                    string insertDelivery = "Insert into Delivery (OrderID, DeliveryID, RestaurantID, deliveryDate, deliveryTime, State, deliveryDetail) VALUES (@OrderID, @DeliveryID, @RestaurantID, @deliveryDate, @deliveryTime, @State, @deliveryDetail)";
                    string insertDeliveryDetail =
                        "INSERT INTO `deliverydetail`(`OrderID`, `DeliveryID`, `ResturantID`, `deliveryDate`, `deliveryTime`, `itemID`, `SupplierssupID`, `itemName`, `State`, `price`, `ResturantName`, `Address`, `itemQuantity`) VALUES" +
                        "@OrderID, @DeliveryID, @ResturantID, @deliveryDate, @deliveryTime, @itemID, @SupplierssupID, @itemName, @State, @price, @ResturantName, @Address, @itemQuantity";
                    // Add placeholder values
                    string deliveryID = "D001";
                    DateTime date = DateTime.Now;
                    string state = "Purchase";
                    using (SqlCommand insertDeliveryCommand = new SqlCommand(insertDelivery, connection))
                    {
                        insertDeliveryCommand.Parameters.AddWithValue("@OrderID", receivedOrderID);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryID", deliveryID);
                        insertDeliveryCommand.Parameters.AddWithValue("@RestaurantID", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryDate", date);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryTime", "8:00");
                        insertDeliveryCommand.Parameters.AddWithValue("@State", state);
                        insertDeliveryCommand.Parameters.AddWithValue("@deliveryDetail", "detail");
                        insertDeliveryCommand.ExecuteNonQuery();
                    }

                    using (SqlCommand insertDeliveryDetailCommand = new SqlCommand(insertDeliveryDetail, connection))
                    {
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@OrderID", receivedOrderID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@DeliveryID", deliveryID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@ResturantID", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@deliveryDate", date);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@deliveryTime", "8:00");
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemID", itemID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@SupplierssupID", "1");
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemName", itemID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@State", state);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@price", 10.0); // Sample price
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@ResturantName", GlobalData.UserInfo.RestaurantID);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@Address", GlobalData.UserInfo.address);
                        insertDeliveryDetailCommand.Parameters.AddWithValue("@itemQuantity", quantity);
                    }
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error inserting data into item_buy table: " + ex.Message);
                }
            }
        }
    }
}