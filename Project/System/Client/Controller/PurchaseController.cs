using Client.Helper;
using Client.Model.Receive;
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
    public class PurchaseController
    {
        public async Task<List<SupplierPurModel>> getSupplier()
        {
            var request = new RestRequest("/api/purchase")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<SupplierPurModel>>(respone.Content);
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
        public async Task<List<PurchaseItemModel>> getItem(string supID)
        {
            var request = new RestRequest("/api/purchase/" + supID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<PurchaseItemModel>>(respone.Content);
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

        public async Task<List<BpaListModel>> getBPA(string supID)
        {
            var request = new RestRequest("/api/purchase/bpa/" + supID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<BpaListModel>>(respone.Content);
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

        public async Task<String> getNewpID(string supID)
        {
            var request = new RestRequest("/api/purchase/bpa/new/" + supID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<string>(respone.Content);
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

        public async Task<bool> CreateNewPurchase(string jsonData,string pid, byte[] pdf)
        {
            var request = new RestRequest("/api/purchase/", Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddParameter("PurchaseData", jsonData, ParameterType.RequestBody)
                .AddFile("files", pdf, pid + ".pdf", "application/pdf");

            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<List<PurchaseRecord>> getRecord()
        {
            var request = new RestRequest("/api/purchase/record")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<List<PurchaseRecord>>(respone.Content);
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

        public async Task<History> getRecordbyID(string pid)
        {
            var request = new RestRequest("/api/purchase/record/" + pid)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    var data = JsonConvert.DeserializeObject<History> (respone.Content);
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

        public async void GetDocs(string pid)
        {
            var request = new RestRequest("/api/purchase/record/" + pid + "/Docs")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.FileName = pid + ".pdf";
                    saveDialog.AddExtension = true;
                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveDialog.FileName;
                        System.IO.File.WriteAllBytes(filePath, response.RawBytes);
                        MessageBox.Show("File downloaded successfully!");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


        public async Task<List<spoListModel>> getSpoData(string supid, List<reqspoModel> itemID)
        {
            var request = new RestRequest("/api/purchase/spo",Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(itemID);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(response.Content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<List<spoListModel>>(response.Content);
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

        public async Task<List<ReqspoModel>> getSpoConData(string supid)
        {
            var request = new RestRequest("/api/purchase/spo/" + supid)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(response.Content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ConList = JsonConvert.DeserializeObject<List<ReqspoModel>>(response.Content);
                    return ConList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }

        public async Task<PPAInfo> getPPA(string supplierID)
        {
            var request = new RestRequest("/api/purchase/ppa/" + supplierID)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(response.Content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var ConList = JsonConvert.DeserializeObject<PPAInfo>(response.Content);
                    return ConList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }
        public async Task updateExp(ExpDateUpdate expDate)
        {
            var request = new RestRequest("/api/purchase/updateDate", Method.Post)
            .AddHeader("Authorization", GlobalData.UserInfo.Token)
            .AddJsonBody(expDate);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(response.Content);
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Expected Date Update Successed");
                    return;
                }
                else
                {
                    MessageBox.Show("Fail to Update Expected Date");
                    return;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task updateDN(DNoteUpdate dNote)
        {
            var request = new RestRequest("/api/purchase/updateNote", Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddJsonBody(dNote);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(response.Content);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Delivery Note Update Success");
                    return;
                }
                else
                {
                    MessageBox.Show("Fail to Update Delivery Note");
                    return;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
