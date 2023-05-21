using RestSharp;
using System;
using System.Threading.Tasks;
using WindowsFormsApp2.Model;
using WindowsFormsApp2.Services;

namespace WebApplication6.Controllers
{
    public class BaseController
    {
        public String ControllerName { get; set; }
        public BaseController(string ControllerName)
        {
            this.ControllerName = ControllerName;
        }

        public RestResponse GetRespone(RestRequest req)
        {
            try
            {
                var response = RestClientServices.client.ExecuteAsync(req).GetAwaiter().GetResult();
                Console.WriteLine(response.Content);
                return response;
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                throw err;
            }
        }
    }
}
