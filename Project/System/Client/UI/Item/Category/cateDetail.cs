using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Controller;
using Client.Model.Receive;

namespace Client.UI.Item.Category
{
    public partial class cateDetail : Form
    {
        private CategoryController categoryController = new CategoryController();
        private RestaurantController restaurantController = new RestaurantController();
        private CategoryItemDto cateInfo;
        private List<RestaurantTypeModel> resturantType;

        public cateDetail(string id)
        {
            InitializeComponent();
            GetData(id);
        }

        private async void GetData(string id)
        {
            var data = await categoryController.getByID(id);
            var RsetTypedata = await restaurantController.getAllRT();
            cateInfo = data;
            resturantType = RsetTypedata;
            BindData();
        }

        private void BindData()
        {
            cateIDTxt.Text = cateInfo.CateId;
            cateNameTxt.Text = cateInfo.CateName;
            reMarkTxt.Text = cateInfo.remark;
            BinditemDataView();
            BindRestView();
        }

        private void BinditemDataView()
        {
            itemDataView.Rows.Clear();
            foreach (var itemData in cateInfo.cateItemInfo)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemDataView,
                    itemData.ItemID,
                    itemData.SupplierID,
                    itemData.Name);
                itemDataView.Rows.Add(row);
            }
            
        }
        private void BindRestView()
        {
            RestView.Rows.Clear();
            foreach (var itemData in cateInfo.resturantInfo)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(RestView,
                    itemData.TypeID,
                    itemData.name,
                    "Remove");
                RestView.Rows.Add(row);
            }

            BindAddRest();
        }

        private void BindAddRest()
        {
            RestTypeBox.Items.Clear();
            var notinview = resturantType
                .Where(rt => !RestView.Rows.Cast<DataGridViewRow>()
                    .Any(row => row.Cells["TypeID"].Value.ToString() == rt.typeId))
                .Where(rt => rt.typeId != "000");
            foreach (var data in notinview)
            {
                RestTypeBox.Items.Add(data.typeId + $" {data.name}");
            }
        }


        private async void addRestBtn_Click(object sender, EventArgs e)
        {
            string rawTypeID = RestTypeBox.Text;
            Regex regex = new Regex("\\s");
            string[] regexData = regex.Split(rawTypeID);
            string typeID = regexData[0].Trim();

            bool status = await categoryController.BindnewRT(cateIDTxt.Text, typeID);
            if (status)
            {
                GetData(cateIDTxt.Text);
                return;
            }

            MessageBox.Show("Error");
        }

        private async void RestView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                string typeID = RestView.Rows[e.RowIndex].Cells["TypeID"].Value.ToString();
                bool status = await categoryController.unBindRT(cateIDTxt.Text, typeID);
                if (status)
                {
                    GetData(cateIDTxt.Text);
                    return;
                }

                MessageBox.Show("Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            string cateID = cateIDTxt.Text;
            string remark = reMarkTxt.Text;
            bool result = await categoryController.EditCate(cateID, remark);
            if (result)
            {
                MessageBox.Show("Success");
                this.Close();
                return;
            }

            MessageBox.Show("Error");
        }
    }
}
