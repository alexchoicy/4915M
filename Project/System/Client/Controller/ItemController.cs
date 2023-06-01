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
using System.Windows.Forms;

namespace Client.Controller
{
    public class ItemController
    {
        public async Task<List<ItemModel>> getAll()
        {
            var request = new RestRequest("/api/Item/")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                MessageBox.Show("start");
                var respone = await ApiClient.client.DeleteAsync(request);
                Debug.WriteLine(respone);
                if(respone.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<List<ItemModel>>(respone.Content);
                    return itemList;
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }
    }
}
