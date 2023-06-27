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
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Tls.Crypto;

namespace Client.UI.USFDelivery
{
    public partial class Delivery : Form
    {
        public Delivery()
        {
            String mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=project; password=";
            string query = "SELECT * FROM delivery";

            using (MySqlConnection connection = new MySqlConnection(mysqlCon))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // set the DataGridView control's DataSource property to the DataTable
                deliveryData.DataSource = dataTable;

                // update the display of the DataGridView control
                deliveryData.Refresh();
            }

            if (deliveryData.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // get the value of the clicked cell
                DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)deliveryData.Rows[e.RowIndex].Cells[e.ColumnIndex];
                string buttonCellValue = buttonCell.Value.ToString();

                // perform some action based on the button value
                if (buttonCellValue == "Detail")
                {
                    // Get the orderID of the selected row
                    string orderID = deliveryData.Rows[e.RowIndex].Cells["orderID"].Value.ToString();

                    Form DeliveryDetail = new DeliveryDetail(orderID);
                    DeliveryDetail.ShowDialog();
                    var Delivery = new Delivery();
                }
            }
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Get the current date and time
            DateTime currentDateTime = DateTime.Now;

            // Set the text of the TextBox control to display the current date and time
            tbDate.Text = currentDateTime.ToString();
        }
    }
}
