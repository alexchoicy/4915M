using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server.Model.Entity
{
    public class purchase
    {
        public string pID { get; set; }
        public string Type { get; set; }
        public DateTime date {get;set;}
        public string supID { get; set; }
        public string ContractID {get;set;}
        public DateTime ExpDate {get;set;}
        [ForeignKey("supID")]
        public virtual Suppliers suppliers { get; set; }
        [ForeignKey("ContractID")]
        public virtual Contract contract {get;set;}
    }
     public class item_Purchase
     {
        public string pID { get; set; }
        public string ItemID { get; set; }
        public double qty {get;set;}
        public double Totalprice {get;set;}
        [ForeignKey("ItemID")]
        public virtual item item { get; set; }
        [ForeignKey("pID")]
        public virtual purchase purchase { get; set; }
     }
}
