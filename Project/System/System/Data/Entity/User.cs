using RestSharp;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Entity
{
    public class User
    {
        [Required]
        public String StaffID { get; set; }
        [Required]
        public String Position { get; set; }
        [Required]
        public String DeptID { get; set; }
        [Required]
        public String ResturantID { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Column(TypeName = "char(1)")]
        public sexEnum sex { get; set; }
        [Required]
        public String Phone { get; set; }
        [Required]
        public String birthdate { get; set; }
        [Required]
        public String password {get;set;}
        public String remark { get; set; }

    }

    public enum sexEnum
    {
        M,F
    }
}
