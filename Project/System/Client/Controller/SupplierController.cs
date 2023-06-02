using Client.Helper;
using Client.Model.Receive;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    public class SupplierController
    {
        public async Task<List<SupplierModel>> getAll()
        {
            var request =new RestRequest("/api/Supplier")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<SupplierModel>>(respone.Content);
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }
    }
}
