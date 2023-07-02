using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UI.NHS2.Mapping
{
    public partial class ViewOrder : UserControl
    {
        public event EventHandler BackButtonClicked;
        public event EventHandler<string> SendOrderIDToMapItem;

        public ViewOrder(string id)
        {
            InitializeComponent();
            InitializeDataGridView();
            dataGridView1.CellContentClick += DataGridView1_CellContentClick;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string orderID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                // Trigger the SendOrderIDToMapItem event instead of EditButtonClicked
                SendOrderIDToMapItem?.Invoke(this, orderID);
            }
            else
            {
                MessageBox.Show("Please select a row to edit.", "No row selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                // Start button clicked
                string orderID = dataGridView1.Rows[e.RowIndex].Cells["orderIDDGV"].Value.ToString();
                SendOrderIDToMapItem?.Invoke(this, orderID);
            }
        }

        private void InitializeDataGridView()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn { Name = "emergency", HeaderText = "Emergency" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "orderIDDGV", HeaderText = "Order ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "restIDDGV", HeaderText = "Restaurant ID" });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn { Name = "statusDGV", HeaderText = "Status" });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Name = "start", HeaderText = "Start", Text = "Start", UseColumnTextForButtonValue = true });

            // Add sample data to dataGridView1
            dataGridView1.Rows.Add(false, "Order1", "Rest1", "Status1");
            dataGridView1.Rows.Add(false, "Order2", "Rest2", "Status2");
            dataGridView1.Rows.Add(true, "Order3", "Rest3", "Status3");
        }
    }
}