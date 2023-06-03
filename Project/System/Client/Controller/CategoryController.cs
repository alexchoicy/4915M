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
using Newtonsoft.Json.Serialization;

namespace Client.Controller
{
    public class CategoryController
    {
        public async Task<List<CategoryModel>> getAll()
        {
            var request = new RestRequest("/api/Category/")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<List<CategoryModel>>(respone.Content);
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

        public async Task<CategoryItemDto> getByID(string id)
        {
            var request = new RestRequest("/api/Category/" + id)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone.StatusCode.ToString());
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<CategoryItemDto>(respone.Content);
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

        public async Task<bool> CreateCate(CategoryModel category)
        {
            string jsonString = JsonConvert.SerializeObject(category);
            var request = new RestRequest("/api/Category", Method.Post)
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

        public async Task<bool> EditCate(string id, string remark)
        {
            var jsonstring = JsonConvert.SerializeObject(new { categoryID = id, remark = remark });
            var request = new RestRequest("/api/Category", Method.Put)
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

        public async Task<bool> BindnewRT(string catID, string typeID)
        {
            var jsonstring = JsonConvert.SerializeObject(new { categoryID = catID, typeID = typeID });

            var request = new RestRequest("/api/Category/Type", Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(jsonstring);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone.StatusCode.ToString());
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<CategoryItemDto>(respone.Content);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return false;
        }

        public async Task<bool> unBindRT(string catID, string typeID)
        {
            var jsonstring = JsonConvert.SerializeObject(new { categoryID = catID, typeID = typeID });

            var request = new RestRequest("/api/Category/Type", Method.Delete)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(jsonstring);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(respone.StatusCode.ToString());
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<CategoryItemDto>(respone.Content);
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return false;
        }
    }
}
