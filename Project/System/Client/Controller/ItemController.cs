using Client.Helper;
using Client.Model.Receive;
using Client.Model.Submit;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Client.Controller
{
    public class ItemController
    {
        public async Task<List<ItemModel>> getAll()
        {
            var request = new RestRequest("/api/Item/", Method.Get)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
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

        public async Task<bool> CreateNewItem(List<ItemCreateModel> items)
        {
            string jsonString = JsonConvert.SerializeObject(items);
            Debug.WriteLine(jsonString);
            var request = new RestRequest("/api/Item", Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(jsonString);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }

        public async Task<bool> EditItemInfo(ItemEditModel items)
        {
            string jsonString = JsonConvert.SerializeObject(items);

            var request = new RestRequest("/api/Item", Method.Put)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(jsonString);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            return false;
        }


    }
}
