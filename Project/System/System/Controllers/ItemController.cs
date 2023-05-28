using System;
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
        //What can Request (rest) or What all item record (admin)
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



        //make a new item and save 0 to the Warehouse inv
        [HttpPost]
        public IActionResult CreateItem([FromBody] List<ItemModel> item)
        {
            var role = User.FindFirst(ClaimTypes.Role)?.Value;

            if (role == "Admin")
            {
                _ = _itemServices.CreateNewitem(item);
                return Ok("Success");
            }

            return BadRequest("You can't add newItem to Warehouse");
        }


        //for restaurant to add new item to the inv database
        [HttpPost("Add")]
        public IActionResult AddItem([FromBody] List<ItemModel> item)
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            var role = User.FindFirst(ClaimTypes.Role)?.Value;
            Console.WriteLine(role);
            if (role == "Manager")
            {
                _ = _itemServices.AddItem(userID,item);
                return Ok("Success");
            }

            return BadRequest("You can't add newItem to system");
        }

        //edit item information
        [HttpPut]
        public IActionResult EditItem([FromBody] EditItemDto item)
        {
            var role = User.FindFirst(ClaimTypes.Role)?.Value;

            if (role == "Admin")
            {
                _ = _itemServices.EditItem(item);
                return Ok("Success");
            }

            return BadRequest("You can't add Edit the item info");
        }






    }
}
