using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model.Receive;

namespace Client.UI.Item.Category
{
    public partial class ShowCate : Form
    {
        private CategoryController categoryController = new CategoryController();
        private List<CategoryModel> data;
        public ShowCate()
        {
            InitializeComponent();
            BindData();
            cateBox.Items.Add("All");
        }

        public async void BindData()
        {
            var data = await categoryController.getAll();
            BindCateData(data);
            this.data = data;
        }

        private void BindCateData(List<CategoryModel> data)
        {
            CateView.Rows.Clear();
            foreach (var category in data)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(CateView,
                    category.CategoryID,
                    category.name,
                    "Detail"
                );
                CateView.Rows.Add(row);
                if (!cateBox.Items.Contains(category.CategoryID))
                {
                    cateBox.Items.Add(category.CategoryID);
                }
            }
        }
        private void cateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cateBox.SelectedIndex == 0)
            {
                BindData();
            }
            else
            {
                var dataIndex = cateBox.SelectedItem.ToString();
                List<CategoryModel> filterdata = data
                    .Where(item => item.CategoryID == dataIndex).ToList();
                BindCateData(filterdata);
            }
        }


        private void CateView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 2)
                {
                    string cateID = CateView.Rows[e.RowIndex].Cells["cateIDView"].Value.ToString();
                    Form cateDetail = new cateDetail(cateID);
                    cateDetail.ShowDialog();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return;
            }
        }

        private void createCateBtn_Click(object sender, EventArgs e)
        {
            Form createCate = new CreateCate();
            createCate.ShowDialog();
        }
    }
}
