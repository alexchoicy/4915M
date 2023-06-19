using AutoMapper;
using Server.Controllers.Input;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class ItemMap : Profile
    {
        public ItemMap()
        {
            CreateMap<item, ItemDto>();


            CreateMap<ItemModel, item>()
                .ForMember(dest => dest.name, opt => opt.MapFrom(src => src.name));


            CreateMap<ItemModel, Restaurant_item>()
                .ForMember(dest => dest.restaurantID,
                    opt => opt.MapFrom(src => "WH000"));
        }
    }

    public class ItemDto
    {
        public string itemId { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string VirtualID { get; set; }
        public int quantity { get; set; }
        public string UOM {get;set;}
    }

    public class EditItemDto
    {
        public string itemID { get; set; }
        public string? CategoryID { get; set; }
        public string? VirtualID { get; set; }
        public string? name { get; set; }
        public double? price { get; set; }
        public string? UOM {get;set;}

    }
}
