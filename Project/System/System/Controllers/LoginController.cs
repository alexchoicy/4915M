using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Services;
namespace Server.Controllers
{
    [ApiController]
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
                else if (succdata.accountLock != null)
                {
                    return BadRequest($"Please Login after {succdata.accountLock}");
                }
                else
                {
                    return BadRequest("Invalid login credentials");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
