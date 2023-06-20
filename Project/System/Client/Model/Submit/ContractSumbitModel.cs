using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Submit
{
    public class ContractSumbitModel
    {
        public ContractDataModel data { get; set; }
        public List<ContractSumbitItemModel> ContractItems { get; set; }
    }

    public class ContractSumbitItemModel
    {
        public string itemID { get; set; }
        public int? quantity { get; set; }
        public double? MOQ { get; set; }
    }

    public class ContractSumbitItemShowModel
    {
        public string itemID { get; set; }
        public string itemName { get; set; }
        public int? quantity { get; set; }
        public double? MOQ { get; set; }
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
    }
}
