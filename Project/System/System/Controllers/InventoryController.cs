using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Model.Dto;
using Server.Services;
using System.Security.Claims;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/Inv")]
    public class InventoryController : ControllerBase
    {
        private readonly IItemServices _itemServices;
                private readonly ILoginServices _loginServices;
        public InventoryController(IItemServices itemServices,ILoginServices loginServices)
        {
            _itemServices = itemServices;
                        _loginServices = loginServices;
        }

        //Edit Inventory quantity
        [HttpPut("Edit")]
        public IActionResult EditInv([FromBody] List<ItemModel> item)
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            _ = _itemServices.EditInv(userID, item);
            return Ok();
        }
        //Update Inventory quantity +-
        [HttpPut("Update")]
        public IActionResult UpdateInv([FromBody] List<ItemModel> item)
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            _ = _itemServices.UpdateInv(userID, item);
            return Ok();
        }

        [HttpGet("Message")]
        public List<Message> Message()
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            return _loginServices.Message(userID);
        }

    }
}
