using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
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
        public InventoryController(IItemServices itemServices)
        {
            _itemServices = itemServices;
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



    }
}
