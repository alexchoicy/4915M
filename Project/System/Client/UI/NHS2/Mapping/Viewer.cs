using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.UI.NHS2.Mapping
{    public partial class Viewer : Form
    {
        private ViewMapping viewMapping;
        private ViewOrder viewOrder;
        private ViewItem viewItem;
        public Viewer()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            viewMapping = new ViewMapping();
            viewMapping.ButtonClicked += ViewMapping_ButtonClicked;
            panel1.Controls.Add(viewMapping);
        }

        private void ViewMapping_ButtonClicked(object sender, string id)
        {
            // Create an instance of ViewOrder user control
            viewOrder = new ViewOrder(id);
            viewOrder.BackButtonClicked += ViewOrder_BackButtonClicked;
            viewOrder.SendOrderIDToMapItem += ViewOrder_EditButtonClicked;
            panel1.Controls.Clear();
            panel1.Controls.Add(viewOrder);
        }

        private void ViewOrder_BackButtonClicked(object sender, EventArgs e)
        {
            // Handle the back button click event from ViewOrder user control
            panel1.Controls.Clear();
            panel1.Controls.Add(viewMapping);
        }

        private void ViewOrder_EditButtonClicked(object sender, string orderID)
        {
            viewItem = new MapItem();
            panel1.Controls.Clear();
            panel1.Controls.Add(viewItem);
        }
    }
}
