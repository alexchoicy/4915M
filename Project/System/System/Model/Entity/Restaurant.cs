using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

    }
}
