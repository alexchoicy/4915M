using AutoMapper;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class CategoryMap : Profile
    {
        public CategoryMap()
        {
            CreateMap<item, CateItemInfo>();

            CreateMap<Category, CategoryItemDto>();

        }
    }


    public class CategoryItemDto
    {
        public string CateId { get; set; }
        public string? CateName { get; set; }
        public string? remark { get; set; }

        public List<CateItemInfo> cateItemInfo { get; set; }
    }

    public class CateItemInfo
    {
        public string? ItemID { get; set; }
        public string? SupplierID { get; set; }
        public string? Name { get; set; }
    }
}
