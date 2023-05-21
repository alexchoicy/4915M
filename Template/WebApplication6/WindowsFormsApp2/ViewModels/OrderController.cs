using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using WebApplication6.Controllers;

namespace WindowsFormsApp2.ViewModels
{
    internal class OrderController : BaseController
    {
        public OrderController(string ControllerName) : base(ControllerName)
        {
            this.ControllerName = ControllerName;
        }
        public RestResponse GetAll()
        {
            var request = new RestRequest("/api/" + ControllerName, Method.Get);
            return (GetRespone(request));
        }
    }
}
