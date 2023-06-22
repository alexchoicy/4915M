using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.Model.Receive;

namespace Client.Model.Local
{
    public class BPAGenModel
    {
        public SupplierModel Supplier { get; set; }
        public List<BPAitemGenModel> items { get; set; }
        public string refNum { get; set; }
        public int BPAid { get; set; }
    }

    public class BPAitemGenModel
    {
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string unit { get; set; }
        public double price { get; set; }
        public double MOQ { get; set; }
        public double qty { get; set; }
        public string refSupID { get; set; }
    }
}
