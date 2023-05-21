using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using WebApplication6.Controllers;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.ViewModels;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private BindingSource bs = new BindingSource();
        private OrderController mb = new OrderController("Order");
        private RestResponse result;
        private DataTable dataTable;
        private List<JObject> order = new List<JObject>();
        private BackgroundWorker bw;
        public Form1()
        {
            dataTable = new DataTable();
            InitializeComponent();
            initDataTable();
            initBackgroundWorker(); 
            bw.RunWorkerAsync();
        }

        private void initBackgroundWorker()
        {
            bw = new BackgroundWorker();
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_WorkFinish);
        }

        private void initDataTable()
        {
            dataTable.Columns.Add("id");
            dataTable.Columns.Add("name");
            dataTable.Columns.Add("pri");
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            getData();
        }

        private void bw_WorkFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            BindtoGrid();
        }
        private void getData()
        {
            result = mb.GetAll();
        }

        private void BindtoGrid()
        {
            dataTable.Clear();
            order.Clear();
            var data = JArray.Parse(result.Content.ToString());
            foreach (JObject row in data)
            {
                DataRow dr = dataTable.NewRow();
                dr["id"] = row["id"].ToString();
                dr["name"] = row["name"].ToString();
                dr["pri"] = row["pri"].ToString();
                order.Add(row);
                dataTable.Rows.Add(dr);
            }

            bs.DataSource = dataTable;
            dataGridView1.DataSource = bs;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            getData();
            BindtoGrid();
        }
    }
}
