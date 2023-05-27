using System.ComponentModel.DataAnnotations;

namespace Server.Model.Entity
{
    public class Suppliers
    {
        [Key]
        public string SupId { get; set; }

        public string SupName { get; set; }

        public string ContactName { get; set; }

        public string ContactEmail { get; set; }

        public string ContactPhone { get; set; }
    }
}
