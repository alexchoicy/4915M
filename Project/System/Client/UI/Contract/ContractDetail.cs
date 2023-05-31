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

namespace Client.UI.Contract
{
    public partial class ContractDetail : Form
    {
        private ContractController contractController = new ContractController();
        public ContractDetail(string ID)
        {
            InitializeComponent();
            bindData(ID);
        }

        public async void bindData(string ID)
        {
            var respone = await contractController.GetDetail(ID);
            cdcontractIdTxt.Text = respone.Contract.ContractID;
            cdSupIDTxt.Text = respone.Contract.SupplierID;
            cdStaffIDTxt.Text = respone.Contract.StaffID;
            cdexpTxt.Text = respone.Contract.ExpireTime.Date.ToShortDateString();
            cdsignTxt.Text = respone.Contract.ExpireTime.Date.ToShortDateString();
            PopulateitemGridView(respone.items);

        }

        private void PopulateitemGridView(List<ContractModelItem> datas)
        {
            itemGridView.AutoGenerateColumns = false;
            BindDataView(datas);
        }

        private void BindDataView(List<ContractModelItem> datas)
        {
            foreach (var itemData in datas)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(itemGridView,
                    itemData.itemID,
                    itemData.CategoryID,
                    itemData.name,
                    itemData.quantity,
                    itemData.price);
                itemGridView.Rows.Add(row);
            }
        }

        private void cdDownBtn_Click(object sender, EventArgs e)
        {
            contractController.GetDetailDocs(cdcontractIdTxt.Text);
        }
    }
}
