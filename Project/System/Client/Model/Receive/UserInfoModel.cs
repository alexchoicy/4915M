using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class UserInformation
    {
        public string Token { get; set; }
        public DateTime ExpireTime { get; set; }
        public string Name { get; set; }
        public string StaffID { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string address { get; set; }
        public string Remark { get; set; }
    }
}
