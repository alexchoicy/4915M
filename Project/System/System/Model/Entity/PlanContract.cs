using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Model.Entity
{
    public class PlanContract
    {
        public int planContractID { get; set; }
        public string ContractID { get; set; }
        public int RepeatDate { get; set; }
        [ForeignKey("ContractID")]
        public virtual Contract Contract { get; set; }
    }

    public class PlanContract_Item
    {
        public int planContractID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("planContractID")]
        public virtual PlanContract planContract { get; set; }
        [ForeignKey("ItemID")]
        public virtual item Item { get; set; }
    }


}
