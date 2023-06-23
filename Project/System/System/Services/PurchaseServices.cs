using AutoMapper;
using Server.Controllers.Input;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IPurchaseServices
    {
        public List<Suppliers> GetSup();
        public List<GetPurItemDto> GetItem(string supid);
        public string getLastID(string supid);
        public bool MakeNewPurchase(PuchaseNewModel data);
        public List<PurchaseRecord> getRecord();
        public History getRecordItem(string pid);
        public List<SpoListDto> getSpoData(List<reqspoModel> itemIds);
    }
    public class PurchaseServices : IPurchaseServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public PurchaseServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }


        public List<Suppliers> GetSup()
        {
            try
            {
                Console.WriteLine("test");
                List<Suppliers> suppliers = (from supplier in _dataContext.suppliers
                        join item in _dataContext.item on supplier.SupplierID equals item.SupplierID
                        join itembuy in _dataContext.item_buy on item.ItemID equals itembuy.ItemID
                        group supplier by supplier.SupplierID into gpSupplier
                        select gpSupplier.First()
                    ).ToList();
                return suppliers;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<GetPurItemDto> GetItem(string supid)
        {
            try
            {
                List<GetPurItemDto> items = (from itemBuy in _dataContext.item_buy
                        join itemData in _dataContext.item on itemBuy.ItemID equals itemData.ItemID
                        where itemData.SupplierID == supid
                        select new GetPurItemDto
                        {
                            ItemID = itemBuy.ItemID,
                            ItemName = itemData.name,
                            itemQty = itemBuy.Quantity
                        }
                    ).ToList();
                return items;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public string getLastID(string supid)
        {
            List<string> pIDdata = (from purchase in _dataContext.purchases
                where purchase.supID == supid
                select purchase.pID).ToList();
            int biggest = -1;
            if(pIDdata.Count == 0)
            {
                return supid + "00000";
            }
            foreach (var item in pIDdata)
            {
                int id = int.Parse(item.Substring(supid.Length));
                if(id > biggest)
                {
                    biggest = id;
                }
            }
            int nextID = biggest + 1;
            string newpID = supid + nextID.ToString().PadLeft(5, '0');
            return newpID;
        }

        public bool MakeNewPurchase(PuchaseNewModel data)
        {
            try
            {
                if (data.files != null && data.files.Count > 0)
                {
                    string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docs", "Purchase");
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
                SumbitDataModel pdata = data.PurchaseData.data;
                string conID = _dataContext.contract.Where(item => item.refsupNum == pdata.refAggreNum).Select(item => item.ContractID).FirstOrDefault();
                purchase newPurchase = new purchase
                {
                    pID = pdata.pid,
                    date = pdata.date,
                    supID = pdata.supID,
                    Type = pdata.Type,
                    ContractID = conID
                };
                _dataContext.purchases.Add(newPurchase);
                _dataContext.SaveChanges();

                foreach (var items in data.PurchaseData.item)
                {
                    item_Purchase newitem = new item_Purchase
                    {
                        pID = items.pID,
                        ItemID = items.itemID,
                        qty = items.qty,
                        Totalprice = items.TotalPrice
                    };
                    _dataContext.item_Purchases.Add(newitem);
                    //process remove item in waiting buy db
                    item_buy itemBuy = _dataContext.item_buy.FirstOrDefault(item => item.ItemID == items.itemID);
                    if (itemBuy.ItemID == items.itemID)
                    {
                        itemBuy.Quantity -= items.qty;
                        if (itemBuy.Quantity <= 0)
                        {
                            _dataContext.item_buy.Remove(itemBuy);
                        }
                        else
                        {
                            _dataContext.item_buy.Update(itemBuy);
                        }
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
            return false;
        }

        //History
        public List<PurchaseRecord> getRecord()
        {
            List<PurchaseRecord> data = _dataContext.purchases.OrderBy(item => item.date).ToList().Select(item => new PurchaseRecord
            {
                pid = item.pID,
                date = item.date,
                supID = item.supID,
                Type = item.Type
            }).ToList();
            return data;
        }

        public History getRecordItem(string pid)
        {
            History data = new History();
            data.record = _dataContext.purchases.Where(item => item.pID == pid).ToList().Select(item => new PurchaseRecord
            {
                pid = item.pID,
                date = item.date,
                supID = item.supID,
                Type = item.Type,
                refAggreNum = item.ContractID
            }).FirstOrDefault();
            List<PurchaseitemRecord> items = (from item in _dataContext.item_Purchases
                join itemData in _dataContext.item on item.ItemID equals itemData.ItemID
                where item.pID == pid
                select new PurchaseitemRecord
                {
                    itemID = item.ItemID,
                    itemName = itemData.name,
                    UOM = itemData.UOM,
                    qty = item.qty,
                    TotalPrice = item.Totalprice
                }).ToList();
            data.items = items;
            return data;
        }


        public List<SpoListDto> getSpoData(List<reqspoModel> itemIds)
        {
            List<SpoListDto> data = new List<SpoListDto>();

            foreach(reqspoModel itemId in itemIds)
            {
                SpoListDto item = _dataContext.item.Where(item => item.ItemID == itemId.itemID).Select(item => new SpoListDto
                {
                    ItemID = item.ItemID,
                    ItemName = item.name,
                    unit = item.UOM,
                    price = item.price
                }).FirstOrDefault();
                data.Add(item);
            }
            return data;
        }

    }
}
