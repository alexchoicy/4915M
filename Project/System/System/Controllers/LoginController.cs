using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Services;
namespace Server.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/Login")]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServices _loginServices;
        public LoginController(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel data)
        {
            try
            {
                if (data.UserID == "String" || data.UserID == "")
                {
                    return NoContent();
                }
                LoginSuccModel succdata;
                var result = _loginServices.Login(data.UserID, data.Password, out succdata);
                if (result == LoginResult.UserNotFound)
                {
                    return NotFound("User not found");
                }
                else if (result == LoginResult.Success)
                {
                    return Ok(succdata);
                }
                else if (result == LoginResult.ToManyTimes || result == LoginResult.LoginLater)
                {
                    return BadRequest($"Please Login after {succdata.accountLock}");
                }
                else if(result == LoginResult.InvalidCredentials)
                {
                    return BadRequest("Invalid login credentials");
                }
                else
                {
                    return BadRequest("error");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost("/Pw")]
        public string password([FromBody] string password)
        {
            return _loginServices.passwordHash(password);
        }
    }
}
