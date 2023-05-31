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
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string ContractType { get; set; }
        public string SupplierID { get; set; }
        public string? StaffID { get; set; }
    }
}
