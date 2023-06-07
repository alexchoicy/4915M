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

namespace test
{
    public partial class RestaurantManager : Form
    {
        private Main mainForm;
        public RestaurantManager(Main mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void CreateOrderbtn_Click(object sender, EventArgs e)
        {
            Requestform requestform = new Requestform();
            requestform.Show();
        }
    }
}
