using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace WindowsFormsApp2.Services
{
    internal class RestClientServices
    {
        public static readonly RestClient client = new RestClient("https://localhost:7011");
    }
}
