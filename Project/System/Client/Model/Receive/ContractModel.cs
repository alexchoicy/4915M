using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Model.Receive
{
    public class ContractModel
    {
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string ContractType { get; set; }
        public string SupplierID { get; set; }
        public string StaffID { get; set; }
        public int? RepeatDate { get; set; }
        public string refsupNum { get; set; }
    }

    public class ContractModelWithItem
    {
        public ContractModel Contract { get; set; }
        public List<ContractModelItem> items { get; set; }
    }

    public class ContractModelItem
    {
        public string itemID { get; set; }
        public string name { get; set; }
        public double? price { get; set; }
        public int quantity { get; set; }
        public string CategoryID { get; set; }
        public double? moq { get; set; }
    }
    public class ContractIDDto
    {
        public string ContractID { get; set; }
        public DateTime ExpireTime { get; set; }
        public string SupplierID { get; set; }
        public string ContractType { get; set; }
    }
}
