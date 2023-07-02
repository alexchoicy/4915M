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
{
    public partial class ViewMapping : UserControl
    {
        public event EventHandler<string> ButtonClicked;
        public ViewMapping()
        {
            InitializeComponent();
            List<MappingData> testData = new List<MappingData>
    {
        new MappingData { MappingDV = "Mapping 1", DateDV = DateTime.Now, statusDV = "Status 1", detailDV = "Detail 1" },
        new MappingData { MappingDV = "Mapping 2", DateDV = DateTime.Now, statusDV = "Status 2", detailDV = "Detail 2" },
        new MappingData { MappingDV = "Mapping 3", DateDV = DateTime.Now, statusDV = "Status 3", detailDV = "Detail 3" }
    };
            // Bind the test data to the DataGridView
            dataGridView1.DataSource = testData;

        }


        public class MappingData
        {
            public string MappingDV { get; set; }
            public DateTime DateDV { get; set; }
            public string statusDV { get; set; }
            public string detailDV { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = "abc";
            ButtonClicked?.Invoke(this, id);
        }

    }
}
