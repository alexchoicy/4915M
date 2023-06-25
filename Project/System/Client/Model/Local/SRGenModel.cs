using Client.Model.Receive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Local
{
     public class SRGenModel
    {
        public string pid { get; set; }
        public string conID { get; set; }
        public string refSupConID { get; set; }
        public string shipName { get; set; }
        public string shipAddress { get; set; }
        public SupplierPurModel Supplier { get; set; }
        public List<SRitemGenModel> item { get; set; }
    }

     public class SRitemGenModel
     {
         public string ItemID { get; set; }
         public string ItemName { get; set; }
         public double price { get; set; }
         public double qty { get; set; }
         public string refSupID { get; set; }
    }
}
