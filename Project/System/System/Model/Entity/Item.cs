using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Model.Entity
{
    public class item
    {
        [Key]
        [Required]
        public string ItemID { get; set; }
        [Required]
        public string SupplierID { get; set; }
        public string? CategoryID { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double price { get; set; }
        [Required]
        public string VirtualID { get; set; }
        [Required]
        public string UOM {get;set;}
        public string refSupID {get;set;}
        [ForeignKey("SupplierID")]
        public virtual Suppliers Suppliers { get; set; }
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; }
    }

    public class Category
    {
        public string CategoryID { get; set; }
        public string? name { get; set; }
        public string? remark { get; set; }
    }
    
    public class AccessControl
    {
        [Key]
        public string typeID { get; set; }
        [Key]
        public string categoryID { get; set; }
        [ForeignKey("categoryID")]
        public virtual Category category { get; set; }
        [ForeignKey("typeID")]
        public virtual RestaurantType RestaurantType { get; set; }
    }

    public class Restaurant_item
    {
        [Key]
        public string restaurantID { get; set; }
        [Key]
        public string itemID { get; set; }
        public double Quantity { get; set; }
        [ForeignKey("restaurantID")]
        public virtual Restaurant restaurant { get; set; }
        [ForeignKey("itemID")]
        public virtual item Item { get; set; }

    }




}
