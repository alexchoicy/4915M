using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Helper;
using Client.Model.Receive;
using Newtonsoft.Json;
using RestSharp;

namespace Client.Controller
{
    public class OrderController
    {
        public async Task<List<OrderModel>> getOrder()
        {
            var request = new RestRequest("/api/Order")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    List<OrderModel> orderList = JsonConvert.DeserializeObject<List<OrderModel>>(respone.Content);
                    return orderList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }
        public async Task<string> getnewID()
        {
            var request = new RestRequest("/api/Order/getNewOrderID")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    string itemList = JsonConvert.DeserializeObject<string>(respone.Content);
                    return itemList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }

        public async Task<bool> createOrder(string jsonString)
        {
            var request = new RestRequest("/api/Order", Method.Post)
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

        public async Task<OrderModelWithItems> getDetail(string orderID)
        {
            var request = new RestRequest("/api/Order/" + orderID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    OrderModelWithItems orderList = JsonConvert.DeserializeObject<OrderModelWithItems>(respone.Content);
                    return orderList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }

        public async Task<string> removeOrder(string orderID)
        {
            var request = new RestRequest("/api/Order/" + orderID,Method.Delete)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    string responeMessage = JsonConvert.DeserializeObject<string>(respone.Content);
                    return responeMessage;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }

        public async Task<bool> editOrder(string jsonstring, string orderID)
        {
            var request = new RestRequest("/api/Order/" + orderID, Method.Put)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(jsonstring);
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
