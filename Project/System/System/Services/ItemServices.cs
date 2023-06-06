using AutoMapper;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Server.Controllers.Input;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IItemServices
    {
        public bool getAll(out IEnumerable<ItemDto> itemsData);
        public bool ItemCanOrder(string staffid, out IEnumerable<ItemDto> itemsData);
        public bool CreateNewitem(List<ItemModel> items);
        public bool AddItem(string userid, List<ItemModel> items);
        public bool EditInv(string userid, List<ItemModel> items);
        public bool UpdateInv(string userid, List<ItemModel> items);
        public bool EditItem(EditItemDto item);
    }
    public class ItemServices : IItemServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;

        public ItemServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }



        //for admin
        public bool getAll(out IEnumerable<ItemDto> itemsData)
        {
            var query = from items in _dataContext.item
                join inv in _dataContext.restaurant_item on items.ItemID equals inv.itemID
                where inv.restaurantID == "WH000"
                select new ItemDto
                {
                    itemId = items.ItemID,
                    SupplierID = items.SupplierID,
                    CategoryID = items.CategoryID,
                    ContractID = items.ContractID,
                    name = items.name,
                    price = items.price,
                    VirtualID = items.VirtualID,
                    quantity = inv.Quantity
                };
            itemsData = query;
            return true;
        }


        //for restaurant to order
        public bool ItemCanOrder(string staffid ,out IEnumerable<ItemDto> itemsData)
        {
            var query = (from staff in _dataContext.staff
                join restaurant in _dataContext.restaurant on staff.RestaurantID equals restaurant.RestaurantId
                join restaurantType in _dataContext.RestaurantType on restaurant.TypeId equals restaurantType.TypeId
                join accessC in _dataContext.AccessControl on restaurantType.TypeId equals accessC.typeID
                join cate in _dataContext.category on accessC.categoryID equals cate.CategoryID
                join items in _dataContext.item on cate.CategoryID equals items.CategoryID
                join inv in _dataContext.restaurant_item on new { RestaurantId = restaurant.RestaurantId, ItemId = items.ItemID } equals new { RestaurantId = inv.restaurantID, ItemId = inv.itemID } into invJoin
                from inv in invJoin.DefaultIfEmpty()
                where staff.StaffID == staffid
                select new ItemDto
                {
                    itemId = items.ItemID,
                    SupplierID = items.SupplierID,
                    name = items.name,
                    CategoryID = items.CategoryID,
                    price = items.price,
                    VirtualID = items.VirtualID,
                    quantity = inv != null ? inv.Quantity : 0
                });
            itemsData = query;
            return true;
        }



        public bool CreateNewitem(List<ItemModel> items)
        {
            foreach (var item in items)
            {
                var query = from itemdata in _dataContext.item
                    where itemdata.ItemID == item.ItemID
                            select itemdata;

                //already have record
                if (query.AsNoTracking() == null)
                {
                    return false;
                }

                var data = _mapper.Map<item>(item);
                var ItemData = _mapper.Map<Restaurant_item>(item);

                _dataContext.item.Add(data);
                _dataContext.restaurant_item.Add(ItemData);

            }

            _dataContext.SaveChanges();
            return true;
        }


        public bool AddItem(string userid, List<ItemModel> items)
        {
            var query = from staff in _dataContext.staff
                where staff.StaffID == userid
                select staff.RestaurantID;
            var restID = query.FirstOrDefault();
            foreach (var item in items)
            {
                var itemData = new Restaurant_item
                {
                    itemID = item.ItemID,
                    restaurantID = restID,
                    Quantity = item.quantity
                };
                _dataContext.restaurant_item.Add(itemData);
            }
            _dataContext.SaveChanges();
            return true;
        }

        public bool EditItem(EditItemDto item)
        {
            var cur = _dataContext.item.Find(item.itemID);
            if (cur == null)
            {
                return false;
            }
            _dataContext.Entry(cur).State = EntityState.Detached;
            var newinfo = new item
            {
                ItemID = cur.ItemID,
                SupplierID = cur.SupplierID,
                CategoryID = !string.IsNullOrEmpty(item.CategoryID) ? item.CategoryID : cur.CategoryID,
                ContractID = !string.IsNullOrEmpty(item.ContractID) ? item.ContractID : cur.ContractID,
                VirtualID = !string.IsNullOrEmpty(item.VirtualID) ? item.VirtualID : cur.VirtualID,
                name = !string.IsNullOrEmpty(item.name) ? item.name : cur.name,
                price = (double)(item.price != null ? item.price : cur.price)
            };
            _dataContext.item.Update(newinfo);
            _dataContext.SaveChanges();

            return true;
        }

        public bool EditInv(string userid, List<ItemModel> items)
        {
            var query = from staff in _dataContext.staff
                where staff.StaffID == userid
                select staff.RestaurantID;
            var restID = query.FirstOrDefault();

            foreach (var item in items)
            {
                var existingItem = _dataContext.restaurant_item.FirstOrDefault(i => i.itemID == item.ItemID && i.restaurantID == restID);
                var itemData = new Restaurant_item
                {
                    itemID = item.ItemID,
                    restaurantID = restID,
                    Quantity = item.quantity
                };
                if (existingItem !=null)
                {
                    _dataContext.restaurant_item.Update(itemData);
                }
                else
                {
                    _dataContext.restaurant_item.Add(itemData);
                }
            }
            _dataContext.SaveChanges();
            return true;
        }

        public bool UpdateInv(string userid, List<ItemModel> items)
        {
            var query = from staff in _dataContext.staff
                where staff.StaffID == userid
                select staff.RestaurantID;
            var restID = query.FirstOrDefault();
            foreach (var item in items)
            {
                var curInvQuery = from rest in _dataContext.restaurant_item
                    where rest.restaurantID == restID
                    where rest.itemID == item.ItemID
                    select rest;
                var curInv = curInvQuery.FirstOrDefault();
                if (curInvQuery != null)
                {
                    curInv.Quantity += item.quantity;
                    _dataContext.restaurant_item.Update(curInv);
                }
            }

            _dataContext.SaveChanges();
            return true;
        }


    }
}
