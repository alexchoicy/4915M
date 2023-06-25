using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model.Receive;

namespace Client.Model.Local
{
    public class SPOGenModel
    {
        public string pid { get; set; }
        public string conID { get; set; }
        public string refSupConID { get; set; }
        public List<SPOitemGenModel> item { get; set; }
        public SupplierPurModel Supplier { get; set; }
    }
    public class SPOitemGenModel
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public double price { get; set; }
        public double qty { get; set; }
        public string refSupID { get; set; }
        public double Totalprice { get; set; }
    }
}
