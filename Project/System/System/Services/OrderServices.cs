using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Server.Controllers.Input;
using Server.Model;
using Server.Model.Dto;
using Server.Model.Entity;
using static Server.Services.OrderServices;

namespace Server.Services
{
    public interface IOrderServices
    {
        public bool GetOrder(string staffid, out IEnumerable<OrderDto> orderData);
        public bool CreateOrder(string staffid, OrderModel orderData);
        public bool EditOrder(string staffid, OrderModel orderData);
        public DelReturn DeleteOrder(string staffid, string orderid);
        public OrderDtoWithItems GetOrderInfo(string orderID);
        public string GetNewOrderID(string restID);
    }
    public class OrderServices : IOrderServices
    {
        private readonly DataContext _dataContext;
        private readonly IMapper _mapper;
        public OrderServices(DataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public bool GetOrder(string staffid, out IEnumerable<OrderDto> orderData)
        {
            var query = from staff in _dataContext.staff
                join restaurant in _dataContext.restaurant on staff.RestaurantID equals restaurant.RestaurantId
                join order in _dataContext.order on restaurant.RestaurantId equals order.restaurantID
                join map in _dataContext.mapping on order.mappingID equals map.MappingId
                where staff.StaffID == staffid
                select new OrderDto{
                    OrderID = order.orderID,
                    status = order.status,
                    CreateTime = order.time,
                    CreatedDate = order.date,
                    emergency = order.emergency,
                    MapLocked = map.Locked,
                };

            orderData = query;
            return true;
        }

        public OrderDtoWithItems GetOrderInfo(string orderID)
        {
            var orderData = (from orderItems in _dataContext.item_order
                join order in _dataContext.order on orderItems.orderID equals order.orderID
                join item in _dataContext.item on orderItems.itemID equals item.ItemID
                where order.orderID == orderID
                select new OrderDtoWithItemsData
                {
                    ItemID = item.ItemID,
                    Name = item.name,
                    Quantity = orderItems.quantity
                }).ToList();
            var orderInfo = _dataContext.order.Find(orderID);
            var orderDataDto = new OrderDtoWithItems
            {
                OrderID = orderInfo.orderID,
                status = orderInfo.status,
                CreateTime = orderInfo.time,
                CreatedDate = orderInfo.date,
                OrderItems = orderData,
                remark = orderInfo.remark,
                emergency = orderInfo.emergency
            };
            return orderDataDto;
        }








        public bool CreateOrder(string staffid, OrderModel orderData)
        {
            var MappingID = _dataContext.mapping
                .FromSqlRaw("SELECT * FROM mapping WHERE MappingID = (SELECT MAX(MappingID) FROM mapping)")
                .FirstOrDefault();
            var order = _mapper.Map<Order>(orderData, opts =>
            {
                opts.Items["staffID"] = staffid;
                opts.Items["MappingID"] = MappingID.MappingId;
            });
            _dataContext.order.Add(order);
            var orderID = order.orderID;
            foreach (var orderitem in orderData.OrderItems)
            {
                var itemData = new Item_Order
                {
                    itemID = orderitem.ItemID,
                    quantity = orderitem.Quantity,
                    orderID = orderID
                };
                _dataContext.item_order.Add(itemData);
            }

            _dataContext.SaveChanges();
            return true;
        }

        public bool EditOrder(string staffid, OrderModel orderData)
        {
            try
            {
                var existingOrder = _dataContext.order.FirstOrDefault(order => order.orderID == orderData.OrderId);
                if (existingOrder == null)
                {
                    // Order with the given ID does not exist
                    return false;
                }
                var query = from map in _dataContext.mapping
                    join order in _dataContext.order on map.MappingId equals order.mappingID
                    where order.orderID == orderData.OrderId
                    select map;
                if (query.FirstOrDefault().Locked)
                {
                    return false;
                }
                existingOrder.date = DateTime.Now.Date;
                existingOrder.time = DateTime.Now.TimeOfDay;
                existingOrder.remark = orderData.remark;
                existingOrder.emergency = orderData.emergency;
                foreach (var orderitems in orderData.OrderItems)
                {
                    var existingItemOrder = _dataContext.item_order.FirstOrDefault(item => item.orderID == orderData.OrderId && item.itemID == orderitems.ItemID);
                    if (existingItemOrder != null)
                    {
                        if (existingItemOrder.itemID == orderitems.ItemID && orderitems.Quantity == 0)
                        {
                            _dataContext.item_order.Remove(existingItemOrder);
                        }
                        else
                        {
                            existingItemOrder.quantity = orderitems.Quantity;
                        }

                    }
                    else
                    {
                        var newOrderItems = new Item_Order
                        {
                            itemID = orderitems.ItemID,
                            quantity = orderitems.Quantity,
                            orderID = orderData.OrderId
                        };
                        _dataContext.item_order.Add(newOrderItems);
                    }
                    _dataContext.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public DelReturn DeleteOrder(string staffid,string orderid)
        {
            var query = from map in _dataContext.mapping
                join order in _dataContext.order on map.MappingId equals order.mappingID
                where order.orderID == orderid
                        select map;
            if (query.FirstOrDefault().Locked)
            {
                return DelReturn.Mapping;
            }

            if (_dataContext.order.FirstOrDefault(order => order.orderID == orderid).reqStaffID != staffid)
            {
                return DelReturn.Notallow;
            }
            var itemsToDelete = _dataContext.item_order.Where(item => item.orderID == orderid);
            _dataContext.item_order.RemoveRange(itemsToDelete);
            var OrderDelete = _dataContext.order.FirstOrDefault(order => order.orderID == orderid);
            _dataContext.order.Remove(OrderDelete);
            _dataContext.SaveChanges();
            return DelReturn.success;
        }

        public enum DelReturn
        {
            Mapping,Notallow,success
        }
        public string GetNewOrderID(string restID)
        {
            List<string> oID = _dataContext.order.Where(order => order.restaurantID == restID).Select(order => order.orderID).ToList();
            int biggest = -1;
            if(oID.Count == 0){
                return restID + "0000";
            }
            foreach (string orderid in oID)
            {
                int id = int.Parse(orderid.Substring(restID.Length));
                if(id > biggest)
                {
                    biggest = id;
                }
            }
            int nextID = biggest + 1;
            string nextIDString = restID + nextID.ToString().PadLeft(3, '0');
            return nextIDString;
        }
    }
}
