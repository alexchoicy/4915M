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
        public ContractDtoWithItem GetById(string id);

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

        public ContractDtoWithItem GetById(string id)
        {
            var contractdata = _dataContext.contract.Find(id);
            var contractmapData = _mapper.Map<ContractDto>(contractdata);

            var itemsData = new List<ContractDtoItem>();
            var data = new ContractDtoWithItem();
            data.Contract = contractmapData;
            if(contractdata.ContractType == "PC")
            {
                var planContract = _dataContext.planContracts.Where(x => x.ContractID == id).FirstOrDefault();
                data.Contract.RepeatDate = planContract.RepeatDate;
                var planContractItemData = _dataContext.planContract_Items.Where(x=> x.planContractID == planContract.planContractID).ToList();
                foreach (var itemData in planContractItemData)
                {
                    var itemInfo = _dataContext.item.Where(x=> x.ItemID == itemData.ItemID).FirstOrDefault(); 
                    var contractItem = new ContractDtoItem
                    {
                        itemID = itemData.ItemID,
                        name = itemInfo.name,
                        price = itemInfo.price,
                        CategoryID = itemInfo.CategoryID,
                        quantity = itemData.Quantity
                    };
                    itemsData.Add(contractItem);
                }
                data.items = itemsData;
                return data;
            }



            var contractItemData = _dataContext.item.Where(x => x.ContractID == id).ToList();
            if (contractItemData != null)
            {

                foreach (var itemData in contractItemData)
                {
                    var itemq = _dataContext.restaurant_item.Where(x => x.itemID == itemData.ItemID && x.restaurantID == "WH000").FirstOrDefault();
                    var contractItem = new ContractDtoItem
                    {
                        itemID = itemData.ItemID,
                        name = itemData.name,
                        price = itemData.price,
                        CategoryID = itemData.CategoryID,
                        quantity = itemq.Quantity
                    };
                    itemsData.Add(contractItem);
                }
                data.items = itemsData;
            };
            return data;
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
                    ContractID = data.contractData.data.ContractID,
                    SignDate = data.contractData.data.SignDate,
                    ExpireTime = data.contractData.data.ExpireTime,
                    ContractType = data.contractData.data.ContractType,
                    SupplierID = data.contractData.data.SupplierID,
                    StaffID = data.contractData.data.StaffID
                };

                _dataContext.contract.Add(newcontract);
                _dataContext.SaveChanges();
                Console.WriteLine(data.contractData.data.ContractID);
                Console.WriteLine(data.contractData.data.RepeatDate);
                if (newcontract.ContractType == "PC")
                {
                    var planContract = new PlanContract
                    {
                        ContractID = data.contractData.data.ContractID,
                        RepeatDate = (int)data.contractData.data.RepeatDate
                    };
                    _dataContext.planContracts.Add(planContract);
                    _dataContext.SaveChanges();
                    int planContractID = planContract.planContractID ?? 0;

                    foreach (var dataitems in data.contractData.ContractItems)
                    {
                        var planItem = new PlanContract_Item
                        {
                            planContractID = planContractID,
                            ItemID = dataitems.itemID,
                            Quantity = dataitems.quantity
                        };
                        _dataContext.planContract_Items.Add(planItem);
                    }
                }
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
