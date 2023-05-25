using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Model.Entity
{
    public class Staff
    {
        [Required]
        public String StaffID { get; set; }
        [Required]
        public String PositionID { get; set; }
        [Required]
        public String DeptID { get; set; }
        [Required]
        public String RestaurantID { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Column(TypeName = "char(1)")]
        public sexEnum sex { get; set; }
        [Required]
        public String Phone { get; set; }
        [Required]
        public DateTime birthdate { get; set; }
        public String remark { get; set; }

        [ForeignKey("PositionID")]
        public virtual Position Position { get; set; }
        [ForeignKey("RestaurantID")]
        public virtual Restaurant Restaurant { get; set; }
        [ForeignKey("DeptID")]
        public virtual Dept Dept { get; set; }
    }

    public enum sexEnum
    {
        M,F
    }
}
