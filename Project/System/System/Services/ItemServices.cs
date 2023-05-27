using AutoMapper;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;

namespace Server.Services
{
    public interface IItemServices
    {
        public bool getAll(out IEnumerable<ItemDto> itemsData);
        public bool ItemCanOrder(string staffid, out IEnumerable<ItemDto> itemsData);
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
            var query = from items in _dataContext.item select _mapper.Map<ItemDto>(items);
            itemsData = query;
            return true;
        }
        //for restaurant to order
        public bool ItemCanOrder(string staffid ,out IEnumerable<ItemDto> itemsData)
        {
            var query = from staff in _dataContext.staff
                join restaurant in _dataContext.restaurant on staff.RestaurantID equals restaurant.RestaurantId
                join restaurantType in _dataContext.RestaurantType on restaurant.TypeId equals restaurantType.TypeId
                join accessC in _dataContext.AccessControl on restaurantType.TypeId equals accessC.typeID
                join cate in _dataContext.category on accessC.categoryID equals cate.CategoryID
                join items in _dataContext.item on cate.CategoryID equals items.CategoryID
                where staff.StaffID == staffid
                select _mapper.Map<ItemDto>(items);
            itemsData = query;
            return true;
        }
    }
}
