using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Client.UI.USFDelivery
{
    public partial class DeliveryDetail : Form
    {
        public DeliveryDetail(string orderID)
        {
            InitializeComponent();
            OrderID = orderID;

            // Add event handlers for the Load event of the form
            this.Load += new EventHandler(DeliveryDetail_Load);
        }

        public string OrderID { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeliveryDetail_Load(object sender, EventArgs e)
        {
            // Call the dataGridView1_CellContentClick method to populate the DataGridView
            dataGridView1_CellContentClick(null, null);

            // Call the tbDeliveryID_TextChanged method to populate the TextBox control
            tbDeliveryID_TextChanged(null, null);

            // Call the tbResturantID_TextChanged method to populate the TextBox control
            tbResturantID_TextChanged(null, null);

            // Call the tbSupplierssupID_TextChanged method to populate the TextBox control
            tbSupplierssupID_TextChanged(null, null);

            // Call the tbDeliveryDate_TextChanged method to populate the TextBox control
            tbDeliveryDate_TextChanged(null, null);

            // Call the tbDeliveryT_TextChanged method to populate the TextBox control
            tbDeliveryT_TextChanged(null, null);

            // Call the tbResturant_TextChanged method to populate the TextBox control
            tbResturant_TextChanged(null, null);

            // Call the tbAddress_TextChanged method to populate the TextBox control
            tbAddress_TextChanged(null, null);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `OrderID`,`itemID`,`itemName`, `price`, `itemQuantity` FROM deliverydetail WHERE orderID = '{OrderID}'";

            using (MySqlConnection connection = new MySqlConnection(mysqlCon))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // set the DataGridView control's DataSource property to the DataTable
                detailData.DataSource = dataTable;

                // update the display of the DataGridView control
                detailData.Refresh();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // create a new Excel application
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;

                // create a new workbook and add a worksheet
                Excel.Workbook workbook = excelApp.Workbooks.Add();
                Excel.Worksheet worksheet = workbook.Sheets.Add();

                // iterate through the columns of the DataGridView control and add the column headers to the worksheet
                int columnCount = detailData.Columns.Count;
                for (int i = 1; i <= columnCount; i++)
                {
                    string cellValue = detailData.Columns[i - 1].HeaderText;
                    worksheet.Cells[1, i] = cellValue;
                }

                // iterate through the rows of the DataGridView control and add the cell contents to the worksheet
                int rowCount = detailData.Rows.Count;
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= columnCount; j++)
                    {
                        string cellValue = detailData.Rows[i - 1].Cells[j - 1].Value != null ? detailData.Rows[i - 1].Cells[j - 1].Value.ToString() : "";
                        worksheet.Cells[i + 1, j] = cellValue;
                    }
                }

                // save the workbook and close Excel
                workbook.SaveAs("Order_Data.xlsx");
                excelApp.Quit();

                // display success message
                MessageBox.Show("Data exported successfully to DataGridView.xlsx.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // display error message
                MessageBox.Show("An error occurred while exporting the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDeliveryID_TextChanged(object sender, EventArgs e)
        {
            tbDeliveryID.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `DeliveryID` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbDeliveryID.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbResturantID_TextChanged(object sender, EventArgs e)
        {
            tbResturantID.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `ResturantID` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbResturantID.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbSupplierssupID_TextChanged(object sender, EventArgs e)
        {
            tbSupplierssupID.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `SupplierssupID` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbSupplierssupID.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbDeliveryDate_TextChanged(object sender, EventArgs e)
        {
            tbDeliveryDate.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `deliveryDate` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbDeliveryDate.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbDeliveryT_TextChanged(object sender, EventArgs e)
        {
            tbDeliveryT.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `deliveryTime` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbDeliveryT.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbResturant_TextChanged(object sender, EventArgs e)
        {
            tbResturant.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `ResturantName` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbResturant.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            tbAddress.ReadOnly = true;
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = $"SELECT `Address` FROM deliverydetail WHERE orderID = '{OrderID}'";

            MySqlConnection conn = new MySqlConnection(mysqlCon);
            MySqlCommand cmd = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    tbAddress.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
