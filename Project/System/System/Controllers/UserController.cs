using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class UserControllers : ControllerBase
    {
        private readonly IUserServices _UserServices;
        public UserControllers(IUserServices userServices)
        {
            _UserServices = userServices;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_UserServices.GetAll());
        }
    }
}