using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class PurchaseItemModel
    {
        public string itemID { get; set; }
        public string itemName { get; set; }
        public int itemQty { get; set; }
    }
    public class BpaListModel
    {
        public int ID { get; set; }
        public string refsupNum { get; set; }
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
}
