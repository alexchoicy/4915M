using Server.Helper;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
namespace Server.Model.Entity
{
    public class Mapping
    {
        [Required]
        [Key]
        public int MappingId { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }
        public string status { get; set; }
        public bool Locked { get; set; }
    }

}
