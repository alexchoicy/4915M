using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Model.Entity
{
    public class BPA
    {
        public int BPAID { get; set; }
        public string ContractID { get; set; }
        [ForeignKey("ContractID")]
        public virtual Contract contract { get; set; }
    }

    public class item_BPA
    {
        public string ItemID { get; set; }
        public int BPAID { get; set; }
        public double price { get; set; }
        public double MOQ { get; set; }
        [ForeignKey("BPAID")]
        public virtual BPA bpa { get; set; }
        [ForeignKey("ItemID")]
        public virtual item item { get; set; }
    }
}
