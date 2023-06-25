using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Client.Helper;
using Client.Model.Receive;
using Newtonsoft.Json;
using RestSharp;

namespace Client.Controller
{
    public class ContractController
    {
        public async Task<List<ContractModel>> getAll()
        {
            var request = new RestRequest("/api/contract/")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var contractList = JsonConvert.DeserializeObject<List<ContractModel>>(response.Content);
                    return contractList;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;
        }

        public async Task<bool> CreateNewContract(string jsonData, string path, string id)
        {
            Debug.WriteLine(jsonData);
            byte[] file = File.ReadAllBytes(path);
            var request = new RestRequest("/api/contract/", Method.Post)
                .AddHeader("Authorization", GlobalData.UserInfo.Token)
                .AddParameter("contractData", jsonData, ParameterType.RequestBody)
                .AddFile("files", file, id + ".pdf", "application/pdf");
            try
            {
                var respone = await ApiClient.client.ExecuteAsync(request);
                if (respone.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }

                MessageBox.Show(respone.StatusCode.ToString());
                return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                throw;
            }
        }

        public async Task<ContractModelWithItem> GetDetail(string id)
        {
            var request = new RestRequest("/api/contract/" + id)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var detail = JsonConvert.DeserializeObject<ContractModelWithItem>(response.Content);
                    return detail;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return null;
        }

        public async void GetDetailDocs(string id)
        {
            var request = new RestRequest("/api/contract/" + id + "/Docs")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.FileName = id + ".pdf";
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

        public async Task<List<ContractIDDto>> getContractIDDto(string id)
        {
            var request = new RestRequest("/api/contract/bySupplier/" + id)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var itemList = JsonConvert.DeserializeObject<List<ContractIDDto>>(response.Content);
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


        public async Task<byte[]> GetDocsinBytes(int BPAid)
        {
            var request = new RestRequest("/api/contract/getBPA/Docs/" + BPAid)
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                Debug.WriteLine(response.RawBytes);
                Debug.Write(response.ResponseStatus);
                return response.RawBytes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public async Task<byte[]> GetConDocsinBytes(string id)
        {
            var request = new RestRequest("/api/contract/" + id + "/Docs")
                .AddHeader("Authorization", GlobalData.UserInfo.Token);
            try
            {
                var response = await ApiClient.client.ExecuteAsync(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.RawBytes;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return null;
        }
    }
}
