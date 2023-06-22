using Microsoft.AspNetCore.Mvc;
using Server.Helper;
using Server.Model.Entity;

namespace Server.Controllers.Input
{
    public class MakeNewContractModel
    {
        [ModelBinder(BinderType = typeof(FormDataJsonBinder))]
        public ContractData contractData { get; set; }
        public IFormFileCollection files { get; set; }

    }

    public class ContractData
    {
        public ContractDataModel data { get; set; }
        public List<ContractSumbitItemModel>? ContractItems { get; set; }
    }
    public class ContractDataModel
    {
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string ContractType { get; set; }
        public string SupplierID { get; set; }
        public string StaffID { get; set; }
        public int? RepeatDate { get; set; }
        public string refsupNum {get;set;}
    }
    public class ContractSumbitItemModel
    {
        public string itemID { get; set; }
        public int? quantity { get; set; }
        public double price {get;set;}
        public double? MOQ { get; set; }
    }
}
