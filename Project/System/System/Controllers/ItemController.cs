using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Model.Entity;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/Item")]
    public class ItemController : ControllerBase
    {
        private readonly IItemServices _itemServices;
        public ItemController(IItemServices itemServices)
        {
            _itemServices = itemServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            var role = User.FindFirst(ClaimTypes.Role)?.Value;
            IEnumerable<ItemDto> items;
            if (userID == null)
            {
                return BadRequest("Error");
            }

            if (role == "Admin")
            {
                _ = _itemServices.getAll(out items);
                return Ok(items);
            }

            _ = _itemServices.ItemCanOrder(userID, out items);
            return Ok(items);
        }

    }
}
