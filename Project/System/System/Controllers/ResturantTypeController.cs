using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using System.Security.Claims;
using Server.Model.Dto;
using Server.Model.Entity;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/RestType")]
    public class ResturantTypeController : ControllerBase
    {
        private readonly IRestTypeServices _restTypeServices;

        public ResturantTypeController(IRestTypeServices restTypeServices)
        {
            _restTypeServices = restTypeServices;
        }
        [HttpGet]
        public IActionResult GetAllType()
        {
            List<RestaurantType> rtData;
            rtData = _restTypeServices.GetAllType();
            return Ok(rtData);
        }

    }
}
