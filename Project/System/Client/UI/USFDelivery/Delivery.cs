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
        private Timer timer;
        public Delivery()
        {
            InitializeComponent();
            this.Load += new EventHandler(Delivery_Load);
            this.FormClosing += new FormClosingEventHandler(Delivery_FormClosing);

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            // Call the dataGridView1_CellContentClick_1 method to populate the DataGridView
            dataGridView1_CellContentClick_1(null, null);

            // Set the current date and time in the TextBox control
            tbDate.Text = DateTime.Now.ToString("HH:m zzz");
        }

        private void Delivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Stop the timer when the form is closing
            timer.Stop();
            timer.Dispose();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // Update the text in the TextBox control with the current date and time
            tbDate.Text = DateTime.Now.ToString();
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

            try
            {
                if (e != null && e.RowIndex >= 0 && e.ColumnIndex == 6)
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
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
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
