using AutoMapper;
using NuGet.Protocol;
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
        public List<ContractIDDto> GetBySupplier(string id);
        public bool MakeNewRec(MakeNewContractModel data);
        public List<BpaListDto> GetBpaInfo(string supID);
        public string getConIDByBPA(string bpaID);
        public PPAInfo getPPAData(string supID);
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
            Console.WriteLine(contractdata.ContractType);
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
                        price = itemData.price,
                        CategoryID = itemInfo.CategoryID,
                        quantity = itemData.Quantity
                    };
                    itemsData.Add(contractItem);
                }
                data.items = itemsData;
                Console.WriteLine(data.ToString());
                return data;
            }
            else if(contractdata.ContractType == "BPA")
            {
                var BPAID = _dataContext.bpa.Where(x => x.ContractID == id).FirstOrDefault();
                var planContractItemData = _dataContext.item_BPA.Where(x => x.BPAID == BPAID.BPAID).ToList();
                foreach (var itemData in planContractItemData)
                {
                    var itemInfo = _dataContext.item.Where(x => x.ItemID == itemData.ItemID).FirstOrDefault();
                    var contractItem = new ContractDtoItem
                    {
                        itemID = itemData.ItemID,
                        name = itemInfo.name,
                        price = itemData.price,
                        CategoryID = itemInfo.CategoryID,
                        MOQ = itemData.MOQ
                    };
                    itemsData.Add(contractItem);
                }
                data.items = itemsData;
                return data;
            }
            return data;
        }

        public List<ContractIDDto> GetBySupplier(string id)
        {
            var contractdata = _dataContext.contract
                .Where(item => item.SupplierID == id && item.ExpireTime > DateTime.Now)
                .Select(Contract => new ContractIDDto
                {
                    ContractID = Contract.ContractID,
                    SupplierID = Contract.SupplierID,
                    ContractType = Contract.ContractType
                }).ToList();
            {
                if (contractdata != null)
                {
                    return contractdata;
                }

                return null;
            }
        }

        public string getConIDByBPA(string bpaID)
        {
            int BPAID = int.Parse(bpaID);
            var BPAdata = _dataContext.bpa.Where(x => x.BPAID == BPAID).FirstOrDefault();
            if (BPAdata != null)
            {
                Console.WriteLine(BPAdata.ContractID);
                return BPAdata.ContractID;
            }
            return null;
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
                    if (!Directory.Exists(folderPath))
                    {
                        // Create the folder
                        Directory.CreateDirectory(folderPath);
                    }
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
                    StaffID = data.contractData.data.StaffID,
                    refsupNum = data.contractData.data.refsupNum
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
                            Quantity =(int)(dataitems.quantity == null ? 0: dataitems.quantity),
                            price = dataitems.price
                        };
                        _dataContext.planContract_Items.Add(planItem);
                    }
                }else if(newcontract.ContractType == "BPA"){
                    BPA bpa = new BPA
                    {
                        ContractID = data.contractData.data.ContractID
                    };
                    _dataContext.bpa.Add(bpa);
                    _dataContext.SaveChanges();
                    int bpaID = bpa.BPAID;

                    foreach(var dataitems in data.contractData.ContractItems)
                    {
                        Console.WriteLine(dataitems.MOQ);
                        item_BPA BpaItem = new item_BPA
                        {
                            ItemID = dataitems.itemID,
                            BPAID = bpaID,
                            price = dataitems.price,
                            MOQ = (double)(dataitems.MOQ == null ? 0:dataitems.MOQ),
                        };
                        _dataContext.item_BPA.Add(BpaItem);
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
        public List<BpaListDto> GetBpaInfo(string supID)
        {
            List<bpaDataDto> bpaid = (from BPA in _dataContext.bpa
                    join Contract in _dataContext.contract on BPA.ContractID equals Contract.ContractID
                    where Contract.SupplierID == supID
                    where Contract.ExpireTime >= DateTime.Now
                    select new bpaDataDto{
                        BPAID = BPA.BPAID,
                        ContractID = BPA.ContractID
                    }).ToList();
            List<BpaListDto> datas = new List<BpaListDto>();

            foreach (bpaDataDto id in bpaid)
            {
                BpaListDto bpadata = new BpaListDto();
                bpadata.ID = id.BPAID;
                bpadata.ContractID = id.ContractID;
                bpadata.refsupNum = _dataContext.contract.Where(x => x.ContractID == _dataContext.bpa.Where(y => y.BPAID == id.BPAID).FirstOrDefault().ContractID).FirstOrDefault().refsupNum;
                List<BpaItemListDto> bpaitems =(
                    from bpaitem in _dataContext.item_BPA
                    join item in _dataContext.item on bpaitem.ItemID equals item.ItemID
                    where bpaitem.BPAID == id.BPAID
                        select new BpaItemListDto
                        {
                            ItemID = bpaitem.ItemID,
                            ItemName = item.name,
                            MOQ = bpaitem.MOQ,
                            price = bpaitem.price,
                            unit = item.UOM,
                            refSupID = item.refSupID
                        }
                    ).ToList();
                bpadata.items = bpaitems;
                datas.Add(bpadata);
            }

            return datas;
        }

        public PPAInfo getPPAData(string supID)
        {
            List<ppaDataDto> ppaid = (from PPA in _dataContext.planContracts
                join contract in _dataContext.contract on PPA.ContractID equals contract.ContractID
                where contract.SupplierID == supID
                where contract.ExpireTime >= DateTime.Now
                select new ppaDataDto{
                    pcID = (int)PPA.planContractID,
                    ContractID = PPA.ContractID
                }).ToList();
            PPAInfo ppaInfo = new PPAInfo();

            List<PPAListDto> datas = new List<PPAListDto>();
            foreach (ppaDataDto data in ppaid)
            {
                PPAListDto ppadata = new PPAListDto();
                ppadata.ID = data.pcID;
                ppadata.ContractID = data.ContractID;
                ppadata.refsupPPANum = _dataContext.contract.Where(x => x.ContractID == data.ContractID).FirstOrDefault().refsupNum;
                List<PPAListItemModel> ppaitems = (
                    from ppaitem in _dataContext.planContract_Items
                    join item in _dataContext.item on ppaitem.ItemID equals item.ItemID
                    where ppaitem.planContractID == data.pcID
                    select new PPAListItemModel
                    {
                        ItemID = ppaitem.ItemID,
                        ItemName = item.name,
                        qty = ppaitem.Quantity,
                        price = ppaitem.price,
                        unit = item.UOM,
                        refSupID = item.refSupID
                    }
                ).ToList();
                ppadata.items = ppaitems;
                datas.Add(ppadata);
            }
            ppaInfo.ppa = datas;
            ppaInfo.restAddress = new List<ppaRestAddressModel>();
            ppaInfo.restAddress = _dataContext.restaurant.ToList().Select(x => new ppaRestAddressModel{
                restId = x.RestaurantId,
                restName = x.RestaurantName,
                restAddress = x.Address
            }).ToList();
            return ppaInfo;
        }

    }
}
