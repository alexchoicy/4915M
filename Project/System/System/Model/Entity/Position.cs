using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server.Model.Entity
{
    public class Position
    { 
        [Required]
        public string PositionID { get; set; }
        [Required]
        public string PositionName { get; set;}
    }
}
