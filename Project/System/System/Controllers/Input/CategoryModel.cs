using AutoMapper;
using Server.Model.Entity;

namespace Server.Controllers.Input
{
    public class MapCate : Profile
    {
        public MapCate() {
            CreateMap<CategoryAccessControlModel, AccessControl>();
        
        }
    }
    public class CategoryItemModel
    {
        public string ItemID { get; set; }
        public string CategoryID { get; set; }

    }
    public class CategoryAccessControlModel
    {
        public string CategoryID { get; set;}
        public string TypeID { get; set;}
    }
}
