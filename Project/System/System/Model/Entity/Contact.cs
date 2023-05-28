using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Model.Entity
{
    public class Contact
    {
        public string ContactID { get; set; }
        public DateTime SignDate { get; set; }
        public string SupplierID { get; set; } // Corrected data type
        public string StaffID { get; set; }
        [ForeignKey("SupplierID")]
        public Suppliers Supplier { get; set; }
        [ForeignKey("StaffID")]
        public Staff staff { get; set; }
    }
}
