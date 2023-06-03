using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace Client.Helper
{
    internal class ApiClient
    {
        public static readonly RestClient client = new RestClient("http://localhost:5000/");
    }
}
