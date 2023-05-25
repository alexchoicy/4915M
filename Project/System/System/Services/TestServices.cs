using AutoMapper;
using Server.Controllers.Input;
using Server.Helper;
using Server.Model;
using Server.Model.Dto;

namespace Server.Services
{
    public interface ITestServices
    {
        bool test(string ID, string password, out LoginDto data);
    }
    public class TestServices : ITestServices
    {
        private readonly DataContext _dataContext;
        private readonly JwtToken _jwtToken;
        private readonly IMapper _mapper;

        public TestServices(DataContext dataContext, JwtToken jwtToken, IMapper mapper)
        {
            _dataContext = dataContext;
            _jwtToken = jwtToken;
            _mapper = mapper;

        }
        public bool test(string ID, string password, out LoginDto data)
        {
            data = new LoginDto();
            var query = from staff in _dataContext.staff
                join ac in _dataContext.account on staff.StaffID equals ac.StaffID
                where staff.StaffID == ID
                select new LoginDto
                {
                    StaffID = staff.StaffID,
                    Name = $"{staff.FirstName} {staff.LastName}",
                    DeptName = staff.Dept.DeptName,
                    PositionName = staff.Position.PositionName,
                    RestaurantName = staff.Restaurant.RestaurantName,
                    password = ac.password,
                    LoginCount = ac.LoginCount,
                    AccountLock = ac.AccountLock
                };
            data = query.FirstOrDefault();
            return true;
        }
    }
}
