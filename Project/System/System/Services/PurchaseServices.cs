using AutoMapper;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IPurchaseServices
    {
        public List<Suppliers> GetSup();
        public List<GetPurItemDto> GetItem(string supid);
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


    }
}
