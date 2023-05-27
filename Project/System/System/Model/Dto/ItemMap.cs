using AutoMapper;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class ItemMap : Profile
    {
        public ItemMap()
        {
            CreateMap<item, ItemDto>();
        }
    }

    public class ItemDto
    {
        public string itemId { get; set; }
        public string SupplierID { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public string VirtualID { get; set; }
    }
}
