using AutoMapper;
using Server.Model.Entity;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Controllers.Input;
using Server.Helper;

namespace Server.Model.Dto
{
    public class OrderMap : Profile
    {
        public OrderMap()
        {
            CreateMap<Order, OrderDto>()
                .ForMember(dest => dest.MapLocked,
                opt => opt.MapFrom(src => src.mapping.Locked))
                .ForMember(dest => dest.CreatedDate, opt =>
                {
                    opt.MapFrom(src => src.date.Date);
                })
                .ForMember(dest => dest.CreateTime, opt => opt.MapFrom(src => TimeSpan.Parse(src.time.ToString())));

            CreateMap<OrderModel, Order>()
                .ForMember(dest => dest.orderID, opt => opt.MapFrom(src => src.OrderId))
                .ForMember(dest => dest.mappingID, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["MappingID"]))
                .ForMember(dest => dest.restaurantID, opt => opt.MapFrom(src => src.RestaurantID))
                .ForMember(dest => dest.reqStaffID, opt => opt.MapFrom((src, dest, destMember, context) => context.Items["staffID"]))
                .ForMember(dest => dest.status, opt => opt.MapFrom(src =>"P"))
                .ForMember(dest => dest.date, opt => opt.MapFrom(src => DateTime.Now.Date))
                .ForMember(dest => dest.time, opt => opt.MapFrom(src => DateTime.Now.TimeOfDay))
                .ForMember(dest => dest.remark, opt => opt.MapFrom(src => src.remark));

        }
    }
    public class OrderDto
    {
        public string OrderID { get; set; }
        public string status { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan CreateTime { get; set; }
        public bool emergency { get; set; }
        public bool MapLocked { get; set; }
    }

    public class OrderDtoWithItems
    {
        public string OrderID { get; set; }
        public string status { get; set; }
        public DateTime CreatedDate { get; set; }
        public TimeSpan CreateTime { get; set; }
        public bool emergency { get; set; }
        public string remark {get;set;}
        public List<OrderDtoWithItemsData> OrderItems { get; set; }
    }
    public class OrderDtoWithItemsData
    {
        public string ItemID { get; set; }
        public string Name { get; set; }
        public double Quantity { get; set; }
    }
}
