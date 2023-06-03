using Client.Helper;
using Client.Model.Submit;
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
    public class InvController
    {
        public async Task<bool> EditItemStock(List<UpdateItem> item)
        {
            string jsonString = JsonConvert.SerializeObject(item);
            Debug.WriteLine(jsonString);
            var request = new RestRequest("/api/Inv/Edit", Method.Put)
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
                MessageBox.Show(respone.StatusCode.ToString());
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
