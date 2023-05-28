using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using System.Security.Claims;
using Server.Model.Dto;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/Order")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        [HttpGet]
        public IActionResult GetOrder()
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            IEnumerable<OrderDto> orderData;
            _ = _orderServices.GetOrder(userID, out orderData);
            return Ok(orderData);
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderInfo(string id)
        {
            var info = _orderServices.GetOrderInfo(id);
            return Ok(info);
        }


        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderModel orderdata)
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            _orderServices.CreateOrder(userID, orderdata);
            return Ok();
        }
        
        [HttpPut("{id}")]
        public IActionResult EditOrder([FromBody] OrderModel orderdata)
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            var status = _orderServices.EditOrder(userID, orderdata);
            if (status)
            {
                return Ok();
            }

            return BadRequest("Please Contact Purchase Manager, The Mapping Process is starting. The Map is locked");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(string id)
        {
            var userID = User.FindFirst(ClaimTypes.Name)?.Value;
            var status = _orderServices.DeleteOrder(userID, id);
            if (status == OrderServices.DelReturn.success)
            {
                return Ok();
            }

            if (status == OrderServices.DelReturn.Notallow)
            {
                return BadRequest("You are not allow to delete the Record");
            }
            return BadRequest("Please Contact Purchase Manager, The Mapping Process is starting. The Map is locked");
        }
    }
}
