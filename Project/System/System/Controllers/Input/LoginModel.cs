using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Server.Controllers.Input
{
    public class LoginModel
    {
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Password { get; set; }
    }

    public class LoginSuccModel
    {
        public class Token
        {
            public string token { get; set; }
            public DateTime expire_time { get; set;}
        }
        public Token userToken { get; set; }
        public UserDataModel userData { get; set; }
        public DateTime? accountLock { get; set; }
    }

    public class UserDataModel
    {
        public string name { get; set; }
        public string staffID { get; set; }
        public string postion { get; set; }
        public string Dept { get; set; }
        public string remark { get; set; }
        public string address { get; set; }
        public string RestaurantID {get;set;}
    }
}
