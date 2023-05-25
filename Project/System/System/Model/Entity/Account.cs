using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Server.Model.Entity
{
    public class Account
    {
        [Key]
        [Required]
        public string StaffID { get; set; }
        [Required]
        public string password { get; set; }
        [Required]
        public int LoginCount { get; set; }
        public DateTime? AccountLock { get; set; }

        [ForeignKey("StaffID")]
        public virtual Staff Staff { get; set; }
    }
}
