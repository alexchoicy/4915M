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
            cdcontractIdTxt.Text = respone.ContractID;
            cdSupIDTxt.Text = respone.SupplierID;
            cdStaffIDTxt.Text = respone.StaffID;
            cdexpTxt.Text = respone.ExpireTime.Date.ToShortDateString();
            cdsignTxt.Text = respone.ExpireTime.Date.ToShortDateString();

        }

        private void cdDownBtn_Click(object sender, EventArgs e)
        {
            contractController.GetDetailDocs(cdcontractIdTxt.Text);
        }
    }
}
