using System.ComponentModel.DataAnnotations;

namespace Server.Model.Entity
{
    public class Suppliers
    {
        [Key]
        public string SupplierID { get; set; }

        public string SupName { get; set; }

        public string Contact_Name { get; set; }

        public string Contact_Email { get; set; }

        public string Contact_Phone { get; set; }
    }
}
