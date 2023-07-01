using System.Configuration;
using System.Diagnostics;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Server.Model;
using Server.Controllers.Input;
using Server.Helper;
using Server.Model.Dto;
using BCrypt.Net;
using System;
using NuGet.Protocol;

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
        public string passwordHash(string password);
        public List<Message> Message(string staffID);
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

        public string passwordHash(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        public LoginResult Login(string ID, string password, out LoginSuccModel data)
        {
            try
            {
                var query = from staff in _dataContext.staff
                            join ac in _dataContext.account on staff.StaffID equals ac.StaffID
                            join rest in _dataContext.restaurant on staff.RestaurantID equals rest.RestaurantId
                            where staff.StaffID == ID
                            select new LoginDto
                            {
                                StaffID = staff.StaffID,
                                Name = $"{staff.FirstName} {staff.LastName}",
                                DeptName = staff.Dept.DeptName,
                                PositionName = staff.Position.PositionName,
                                RestaurantName = staff.Restaurant.RestaurantName,
                                RestaurantID = staff.RestaurantID,
                                password = ac.password,
                                LoginCount = ac.LoginCount,
                                AccountLock = ac.AccountLock,
                                address = rest.Address,
                                remark = staff.remark
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
                    data.accountLock = account.AccountLock;
                    return LoginResult.LoginLater;
                }
                else if (request.AccountLock < DateTime.Now)
                {
                    if (account != null)
                    {
                        account.LoginCount = 0;
                        _dataContext.account.Update(account);
                        _dataContext.SaveChanges();
                    }
                }
                if (account.LoginCount >= 5)
                {
                    if (account != null)
                    {
                        request.AccountLock = DateTime.Now.AddMinutes(30);
                        account.AccountLock = request.AccountLock;
                        _dataContext.account.Update(account);
                        _dataContext.SaveChanges();
                        data.accountLock = account.AccountLock;
                        return LoginResult.ToManyTimes;
                    }
                    return LoginResult.UserNotFound;
                }
                if (!BCrypt.Net.BCrypt.Verify(password, request.password))
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
                Debug.WriteLine(password + " " + request.password);
                //reset the account Lockdown
                account.LoginCount = 0;
                account.AccountLock = null;
                _dataContext.account.Update(account);
                _dataContext.SaveChanges();
                //Create Token
                LoginSuccModel.Token newToken = new LoginSuccModel.Token();
                string restID = _dataContext.staff.Where(x => x.StaffID == ID).Select(x => x.RestaurantID).FirstOrDefault();
                newToken.token = _jwtToken.Creater(request.StaffID, request.PositionName, request.DeptName, restID);
                newToken.expire_time = DateTime.Now.AddHours(5);
                data.userToken = newToken;
                //bind userData
                UserDataModel userData = new UserDataModel();
                userData.name = request.Name;
                userData.staffID = ID;
                userData.postion = request.PositionName;
                userData.Dept = request.DeptName;
                userData.remark = request.remark;
                userData.address = request.address;
                userData.RestaurantID = request.RestaurantID;
                data.userData = userData;

                return LoginResult.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public List<Message> Message(string staffID)
        {
            var query = from msg in _dataContext.notificat
            join Type in _dataContext.dept on msg.Type equals Type.DeptName
            join staff in _dataContext.staff on Type.DeptId equals staff.DeptID
            where staff.StaffID == staffID
            select new Message
            {
                messages = msg.Message,
                Datetime = msg.Datetime
            };
            Console.WriteLine(staffID);
            return query.ToList();
        }
    }
}