using AutoMapper;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class ContractMap : Profile
    {
        public ContractMap()
        {
            CreateMap<Contract, ContractDto>();

            CreateMap<ContractDto, Contract>();
        }
    }



    public class ContractDto
    {
        public string ContractID { get; set; }
        public DateTime SignDate { get; set; }
        public DateTime ExpireTime { get; set; }
        public string ContractType { get; set; }
        public string SupplierID { get; set; }
        public string? StaffID { get; set; }
    }
}
