using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Submit
{
    public class ItemCreateModel
    {
        public string itemId { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string VirtualID { get; set; }
        public int? quantity { get; set; } = 0;
        public string UOM { get; set; }
    }
}
