using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Model.Entity
{
    public class Contract
    {
        [Key]
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string ContractType { get; set; }
        public string SupplierID { get; set; }
        public string? StaffID { get; set; }




        [ForeignKey("SupplierID")]
        public virtual Suppliers Supplier { get; set; }
        [ForeignKey("StaffID")]
        public virtual Staff staff { get; set; }
    }
}
