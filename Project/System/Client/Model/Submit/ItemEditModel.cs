using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Submit
{
    public class ItemEditModel
    {
        public string itemID { get; set; }
        public string CategoryID { get; set; }
        public string VirtualID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string uom { get; set; }
        public string refSupID { get; set; }
    }

    public class UpdateItem
    {
        public string itemID { get; set; }
        public int quantity { get; set; }
    }

}
