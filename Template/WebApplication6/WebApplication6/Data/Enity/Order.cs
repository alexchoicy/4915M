using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Data.Enity
{
    public class Order
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Pri { get; set; }

    }
}
