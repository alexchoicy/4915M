using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Server.Model.Entity
{
    public class Dept
    {
        [Required]
        public string DeptId { get; set; }
        [Required]
        public string DeptName { get; set;}

    }
}
