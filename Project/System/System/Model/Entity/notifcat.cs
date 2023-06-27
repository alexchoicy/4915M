using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server.Model.Entity
{
    public class notificat{
        public int ID {get;set;}
        public string restID {get;set;}
        public string Message {get;set;}
        public string Type {get;set;}
        public DateTime Datetime { get; set; }
        [ForeignKey("restID")]
        public virtual Restaurant restaurant {get;set;}
    }
}