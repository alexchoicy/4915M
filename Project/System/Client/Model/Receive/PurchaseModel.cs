using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class SupplierPurModel
    {
        public string SupplierID { get; set; }
        public string SupName { get; set; }

        public string Contact_Name { get; set; }

        public string Contact_Email { get; set; }

        public string Contact_Phone { get; set; }

        public string address { get; set; }
        public bool exist { get; set; }
    }
    public class PurchaseItemModel
    {
        public string itemID { get; set; }
        public string itemName { get; set; }
        public double itemQty { get; set; }
    }
    public class BpaListModel
    {
        public int ID { get; set; }
        public string refsupNum { get; set; }
        public string ContractID { get; set; }
        public List<BpaItemListModel> items { get; set; }
    }
    public class BpaItemListModel
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double MOQ { get; set; }
        public string refSupID { get; set; }
    }

    public class ReqspoModel
    {
        public string contractID { get; set; }
        public string refsupNum { get; set; }
    }

    public class spoListModel
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public string refSupID { get; set; }
    }
    public class PPAInfo
    {
        public List<PPAListModel> ppa { get; set; }
        public List<ppaRestAddressModel> restAddress { get; set; }

    }
    public class PPAListModel
    {
        public int ID { get; set; }
        public string refsupPPANum { get; set; }
        public string ContractID { get; set; }
        public List<PPAListItemModel> items { get; set; }
    }


    public class PPAListItemModel
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double qty { get; set; }
        public string refSupID { get; set; }
    }
    public class ppaRestAddressModel
    {
        public string restId { get; set; }
        public string restName { get; set; }
        public string restAddress { get; set; }
    }

    public class History
    {
        public PurchaseRecord record { get; set; }
        public List<PurchaseitemRecord> items { get; set; }
    }
    public class PurchaseRecord
    {
        public string pid { get; set; }
        public string Type { get; set; }
        public string refAggreNum { get; set; }
        public string supID { get; set; }
        public DateTime date { get; set; } = DateTime.Now;
    }

    public class PurchaseitemRecord
    {
        public string itemID { get; set; }
        public string itemName { get; set; }
        public string UOM { get; set; }
        public double qty { get; set; }
        public double TotalPrice { get; set; }
    }

}
