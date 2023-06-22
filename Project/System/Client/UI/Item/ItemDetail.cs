using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using Client.Controller;
using Client.Helper;
using Client.Model.Receive;
using Client.Model.Submit;

namespace Client.UI.Item
{
    public partial class ItemDetail : Form
    {
        private ItemModel data;
        private List<string> categoryItems;
        private ItemController itemController = new ItemController();
        private InvController invController = new InvController();
        private ContractController contractController = new ContractController();
        private List<ContractIDDto> contractData;
        public ItemDetail(ItemModel itemdata, List<string> categoryItems)
        {
            InitializeComponent();
            data = itemdata;
            this.categoryItems = categoryItems;
            BindDataViewItem();
            BindBox();
            if (GlobalData.UserInfo.Department == "Restaurant")
            {
                cateIDTxt.DropDownStyle = ComboBoxStyle.DropDownList;
                virtualIDTxt.ReadOnly = true;
                itemNameTxt.ReadOnly=true;
                priceTxt.ReadOnly=true;
            }
        }

        private void BindBox()
        {
            foreach (var item in categoryItems)
            {
                cateIDTxt.Items.Add(item);
            }
        }

        private void BindDataViewItem()
        {
            itemIdTxt.Text = data.itemId;
            supplierIDTxt.Text = data.SupplierID;
            cateIDTxt.Text = data.CategoryID;
            virtualIDTxt.Text = data.VirtualID;
            itemNameTxt.Text = data.name;
            priceTxt.Text = data.price.ToString();
            stockTxt.Text = data.quantity.ToString();
            UOMList.Text = data.UOM;
            refSupID.Text = data.refSupID;
            getContractBysup(data.SupplierID);
        }
        private async void getContractBysup(string id)
        {
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {

            string itemID = itemIdTxt.Text;
            string supID = supplierIDTxt.Text;
            string cateID = cateIDTxt.Text;
            string virtualID = virtualIDTxt.Text;
            string name = itemNameTxt.Text;
            string rawprice = priceTxt.Text;
            string rawstock = stockTxt.Text;
            string UOM = UOMList.Text;
            string refSupID = this.refSupID.Text;
            int stock;
            if (!int.TryParse(rawstock, out stock))
            {
                MessageBox.Show("Incorrect data of Stock");
                return;
            }

            if (GlobalData.UserInfo.Department == "Restaurant")
            {
                List<UpdateItem> updateRestInvsList = new List<UpdateItem>();
                UpdateItem updateRestInv = new UpdateItem
                {
                    itemID = itemID,
                    quantity = stock
                };
                updateRestInvsList.Add(updateRestInv);
                bool editRestInv = await invController.EditItemStock(updateRestInvsList);
                
                if (!editRestInv)
                {
                    MessageBox.Show("Error while Edit the inventory stock");
                }
                else
                {
                    MessageBox.Show("Update Success");
                }
                return;
            }

            double price;
            if (!double.TryParse(rawprice, out price))
            {
                MessageBox.Show("Incorrect data of Price");
                return;
            }


            //check cateID
            bool catIDcheck = false;

            foreach (var item in categoryItems)
            {
                if (cateID == item)
                {
                    catIDcheck = true;
                    break;
                }
            }

            if (!catIDcheck)
            {
                MessageBox.Show("Incorrect CateItem ID");
                return;
            }


            if (string.IsNullOrEmpty(virtualID))
            {
                virtualID = data.VirtualID;
            }

            if (virtualID != data.VirtualID)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to change the Virtual ID to " + virtualID, "Confirm Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            if (string.IsNullOrEmpty(name))
            {
                name = data.name;
            }

            if (name != data.name)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to change the Name to " + name, "Confirm Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            if (string.IsNullOrEmpty(UOM))
            {
                UOM = data.UOM;
            }

            if (name != data.name)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to change the UOM to " + UOM, "Confirm Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            if (string.IsNullOrEmpty(name))
            {
                name = data.name;
            }

            if (name != data.name)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to change the Name to " + name, "Confirm Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }


            if (price != data.price)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Update the Price to " + price, "Confirm Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }

            if (stock != data.quantity)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to Update the Stock to " + stock, "Confirm Box", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            if(cateID == "All")
            {
                cateID = "MC";
            }
            ItemEditModel editData = new ItemEditModel
            {
                CategoryID = cateID,
                itemID = itemID,
                name = name,
                price = price,
                VirtualID = virtualID,
                uom = UOM,
                refSupID = refSupID,
            };

            UpdateItem updateInv = new UpdateItem
            {
                itemID = itemID,
                quantity = stock
            };
            List<UpdateItem> updateInvsList = new List<UpdateItem>();
            updateInvsList.Add(updateInv);
            bool editResult = await itemController.EditItemInfo(editData);
            bool editInv = await invController.EditItemStock(updateInvsList);

            if (editInv && editResult)
            {
                MessageBox.Show("Success");
                DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            if (!editResult)
            {
                MessageBox.Show("Error while update the item Info");
            }

            if (!editInv)
            {
                MessageBox.Show("Error while Edit the inventory stock");
            }
            DialogResult = DialogResult.Retry;
            this.Close();
            return;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
