using System.Configuration;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using Server.Controllers.Input;
using Server.Helper;
using Server.Model.Dto;

namespace Server.Services
{
    public enum LoginResult
    {
        UserNotFound,
        Success,
        InvalidCredentials,
        ToManyTimes,
        LoginLater
    }
    public interface ILoginServices
    {
        LoginResult Login(string ID,string password, out LoginSuccModel data);
    }
    public class LoginServices : ILoginServices
    {
        private readonly DataContext _dataContext;
        private readonly JwtToken _jwtToken;
        private readonly IMapper _mapper;

        public LoginServices(DataContext dataContext, JwtToken jwtToken, IMapper mapper)
        {
            _dataContext = dataContext;
            _jwtToken = jwtToken;
            _mapper = mapper;

        }
        public LoginResult Login(string ID, string password, out LoginSuccModel data)
        {
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

            var request = query.FirstOrDefault();
            data = new LoginSuccModel();
            var account = _dataContext.account.FirstOrDefault(a => a.StaffID == ID);
            if (request == null)
            {
                data = null;
                return LoginResult.UserNotFound;
            }
            if (request.AccountLock > DateTime.Now)
            {
                data.accountLock = request.AccountLock;
                return LoginResult.LoginLater;
            }
            if (request.LoginCount >= 5)
            {
                if (account != null)
                {
                    request.AccountLock = DateTime.Now.AddMinutes(30);
                    account.AccountLock = request.AccountLock;
                    _dataContext.account.Update(account);
                    _dataContext.SaveChanges();
                    return LoginResult.ToManyTimes;
                }
                return LoginResult.UserNotFound;
            }
            if (!password.Equals(request.password))
            {
                if (account != null)
                {
                    request.LoginCount++;
                    account.LoginCount = request.LoginCount;
                    _dataContext.account.Update(account);
                    _dataContext.SaveChanges();
                    return LoginResult.InvalidCredentials;
                }
                return LoginResult.UserNotFound;
            }
            //reset the account Lockdown
            account.LoginCount = 0;
            account.AccountLock = null;
            _dataContext.account.Update(account);
            _dataContext.SaveChanges();
            //Create Token
            LoginSuccModel.Token newToken = new LoginSuccModel.Token();
            newToken.token = _jwtToken.Creater(request.StaffID, request.PositionName);
            newToken.expire_time = DateTime.Now.AddHours(5);
            data.userToken = newToken;
            //bind userData
            UserDataModel userData = new UserDataModel();
            userData.name = request.Name;
            userData.staffID = ID;
            userData.postion = request.PositionName;
            userData.Dept = request.DeptName;
            var user = _dataContext.staff.Find(ID);
            userData.remark = user.remark;
            data.userData = userData;
            
            return LoginResult.Success;
        }

    }
}