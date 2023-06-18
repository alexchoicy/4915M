using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Model.Entity
{
    public class Buy
    {
        public int BuyID { get; set; }
        public int MappingID { get; set; }
        [ForeignKey("Mapping")]
        public virtual Mapping mapping { get; set; }
    }

    public class item_buy
    {
        public int BuyID { get; set; }
        public string ItemID { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("BuyID")]
        public virtual Buy buy { get; set; }
        [ForeignKey("ItemID")]
        public virtual item item { get; set; }
    }
}
