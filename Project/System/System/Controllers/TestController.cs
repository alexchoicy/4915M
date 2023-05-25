using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ITestServices _testServices;
        public TestController(ITestServices testServices)
        {
            _testServices = testServices;
        }

        [HttpGet]
        public IActionResult test()
        {
            return Ok("test");
        }

        [HttpPost]
        public IActionResult post([FromBody] LoginModel data)
        {
            LoginDto succdata;
            var result = _testServices.test(data.UserID, data.Password, out succdata);
            return Ok(succdata);
        }
    }
}
