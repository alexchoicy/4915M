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
    public partial class CreateCate : Form
    {
        private CategoryController categoryController = new CategoryController();
        public CreateCate()
        {
            InitializeComponent();
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            string cateID = cateIDTxt.Text;
            string cateName = cateNameTxt.Text;
            string remark = reMarkTxt.Text;

            CategoryModel cate = new CategoryModel
            {
                CategoryID = cateID,
                name = cateName,
                remark = remark
            };
            bool result = await categoryController.CreateCate(cate);
            if (result)
            {
                MessageBox.Show("Success");
                this.Close();
                return;
            }

            MessageBox.Show("Error");
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
