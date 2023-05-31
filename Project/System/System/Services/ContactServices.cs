using AutoMapper;
using Server.Controllers.Input;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IContractServices
    {
        public List<ContractDto> GetAll();
        public ContractDto GetById(string id);

        public bool MakeNewRec(MakeNewContractModel data);

    }

    public class ContractServices : IContractServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public ContractServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public List<ContractDto> GetAll()
        {
            var contractdata = _dataContext.contract;
            var ontractmapData = _mapper.Map<List<ContractDto>>(contractdata);

            return ontractmapData;
        }

        public ContractDto GetById(string id)
        {
            var contractdata = _dataContext.contract.Find(id);
            var contractmapData = _mapper.Map<ContractDto>(contractdata);
            return contractmapData;
        }

        public bool MakeNewRec(MakeNewContractModel data)
        {
            try
            {
                Console.WriteLine("start");
                //file store
                if (data.files != null && data.files.Count > 0)
                {
                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docs", "Contract");

                    foreach (var file in data.files)
                    {
                        string filePath = Path.Combine(folderPath, file.FileName);
                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            file.CopyTo(stream);
                        }
                    }

                }

                var newcontract = new Contract
                {
                    ContractID = data.contractData.ContractID,
                    SignDate = data.contractData.SignDate,
                    ExpireTime = data.contractData.ExpireTime,
                    ContractType = data.contractData.ContractType,
                    SupplierID = data.contractData.SupplierID,
                    StaffID = data.contractData.StaffID
                };



                _dataContext.contract.Add(newcontract);
                _dataContext.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }


    }
}
