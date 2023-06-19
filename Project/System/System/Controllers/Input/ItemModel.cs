using System.ComponentModel.DataAnnotations.Schema;
using Server.Model.Entity;

namespace Server.Controllers.Input
{

    public class ItemModel
    {
        public string ItemID { get; set; }
        public string? SupplierID { get; set; }
        public string? CategoryID { get; set; }
        public string? name { get; set; }
        public double? price { get; set; }
        public string? virtualID { get; set; }
        public string? UOM {get;set;}
        public int quantity { get; set; } = 0;
    }
}
