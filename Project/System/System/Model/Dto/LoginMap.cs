
using AutoMapper;
using Server.Model.Entity;

namespace Server.Model.Dto
{
    public class LoginMap : Profile
    {
        public LoginMap()
        {
            CreateMap<Staff, LoginDto>()
                .ForMember(dest => dest.PositionName, opt => opt.MapFrom(src => src.Position.PositionName));
            CreateMap<Account, LoginDto>()
                .ForMember(dest => dest.password, opt => opt.MapFrom(src => src.password));
            CreateMap<Staff, LoginDto>()
                .ForMember(dest => dest.RestaurantName, opt => opt.MapFrom(src => src.Restaurant.RestaurantName));
        }

    }

    public class LoginDto
    {
        public string StaffID { get; set; }
        public string Name { get; set; }
        public string DeptName { get; set; }
        public string PositionName { get; set; }
        public string RestaurantName { get; set; }
        public string password { get; set; }
        public int LoginCount { get; set; }
        public DateTime? AccountLock { get; set; }
        public string address { get; set; }
        public string remark {get; set; }
    }
}
