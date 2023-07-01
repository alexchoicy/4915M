using Server.Helper;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Server.Helper;
using MessagePack;

namespace Server.Model.Entity
{
    public class Order
    {
        [Required]
        public string orderID { get; set; }
        [Required]
        public int mappingID { get; set; }
        [Required]
        public string restaurantID { get; set; }
        [Required]
        public string reqStaffID { get; set; }

        public string? doneStaffID { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required] 
        public TimeSpan time { get; set; }
        public bool emergency { get; set; }
        public string remark { get; set; }
        [ForeignKey("reqStaffID")]
        public virtual Staff reqStaff { get; set; }
        [ForeignKey("doneStaffID")]
        public virtual Staff? doneStaff { get;set; }
        [ForeignKey("restaurantID")]
        public virtual Restaurant restaurant { get; set; }
        [ForeignKey("mappingID")]
        public virtual Mapping mapping { get; set; }
    }


    public class Item_Order
    {
        [System.ComponentModel.DataAnnotations.Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string itemID { get; set; }
        public string orderID { get; set; }
        public double quantity { get; set; }
        [ForeignKey("itemID")]
        public virtual item item { get; set; }
        [ForeignKey("orderID")]
        public virtual Order order { get; set; }


    }
}
