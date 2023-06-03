using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class ItemModel
    {
        public string itemId { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string ContractID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string VirtualID { get; set; }
        public int quantity { get; set; }

    }
}
