using Client.Helper;
using Client.Model.Receive;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controller
{
    public class RestaurantController
    {
        public async Task<List<RestaurantTypeModel>> getAllRT()
        {
            var request = new RestRequest("/api/RestType/", Method.Get)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<List<RestaurantTypeModel>>(respone.Content);
                    return itemList;
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
