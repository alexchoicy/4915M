using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Model.Entity
{
    public class Restaurant
    {
        [Required]
        public string RestaurantId { get; set; } = null!;
        [Required]
        public string TypeId { get; set; }
        [Required]
        public string RestaurantName { get; set; }
        [Required]
        public string Address { get; set; }
        [ForeignKey("TypeId")]
        public virtual RestaurantType RestaurantType { get; set; }
    }

    public class RestaurantType
    {
        [Key]
        public string TypeId { get; set; }
        public string name { get; set; }
    }
}
