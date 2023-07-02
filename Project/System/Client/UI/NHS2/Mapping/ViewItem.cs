using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Sql;


namespace Client.UI.NHS2.Mapping
{
    public partial class ViewItem : UserControl
    {
        public ViewItem(string orderID)
        {
            InitializeComponent();
            SetOrderID(orderID);
            InitializeDataGridView();
            LoadItemData();
        }

        private void LoadItemData()
        {
            using (SqlConnection cnn = new SqlConnection(myConnectionString))
            {
                try
                {
                    cnn.Open();

                    using (SqlCommand command = new SqlCommand("SELECT ItemID, SupplierID, CategoryID, Name, price, VirtualID, UOM, refSupID FROM Item WHERE `orderID` = @orderID", cnn))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(
                                    reader["ItemID"],
                                    reader["SupplierID"],
                                    reader["CategoryID"],
                                    reader["Name"],
                                    reader["price"],
                                    reader["VirtualID"],
                                    reader["UOM"],
                                    reader["refSupID"]
                                );
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot open connection!");
                }
            }
        }

        public void SetOrderID(string orderID)
        {
            textBox1.Text = orderID;
        }

        private string myConnectionString = "server=localhost;database=testDB;uid=root;pwd=;";

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.AddRange(new DataGridViewColumn[]
            {
        new DataGridViewTextBoxColumn { Name = "ItemID", HeaderText = "Item ID" },
        new DataGridViewTextBoxColumn { Name = "SupplierID", HeaderText = "Supplier ID" },
        new DataGridViewTextBoxColumn { Name = "CategoryID", HeaderText = "Category ID" },
        new DataGridViewTextBoxColumn { Name = "Name", HeaderText = "Name" },
        new DataGridViewTextBoxColumn { Name = "price", HeaderText = "Price" },
        new DataGridViewTextBoxColumn { Name = "VirtualID", HeaderText = "Virtual ID" },
        new DataGridViewTextBoxColumn { Name = "UOM", HeaderText = "UOM" },
        new DataGridViewTextBoxColumn { Name = "refSupID", HeaderText = "Ref Supplier ID" },
            });
        }

        public static implicit operator ViewItem(MapItem v)
        {
            throw new NotImplementedException();
        }
    }
}