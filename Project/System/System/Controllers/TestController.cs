using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        private readonly ITestServices _testServices;
        public TestController(ITestServices testServices)
        {
            _testServices = testServices;
        }
        // [Authorize]
        // [HttpGet]
        // public IActionResult test()
        // {
        //     return Ok("test");
        // }

        // [HttpPost]
        // public IActionResult post([FromBody] LoginModel data)
        // {
        //     LoginDto succdata;
        //     var result = _testServices.test(data.UserID, data.Password, out succdata);
        //     return Ok(succdata);
        // }



        [HttpGet]
        public IActionResult TestJwt([FromHeader(Name = "Authorization")] string authorization)
        {
            Console.WriteLine(authorization);
            if (!string.IsNullOrEmpty(authorization) && authorization.StartsWith("Bearer "))
            {
                var jwtToken = authorization.Substring("Bearer ".Length);

                // Validate the JWT token here using your own validation logic
                // You can use a library like System.IdentityModel.Tokens.Jwt to validate the token

                // For testing purposes, let's assume the JWT is valid if it contains the string "test"
                bool isValidJwt = jwtToken.Contains("test");

                return Ok(isValidJwt);
            }

            return Ok(false);
        }

    }
}
