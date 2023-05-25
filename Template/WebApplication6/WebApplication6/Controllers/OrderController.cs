using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderServices _orderServices;

        public OrderController(IOrderServices orderServices)
        {
            _orderServices = orderServices;
        }
        [HttpGet]
        public IActionResult GetAll(){
            return Ok(_orderServices.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_orderServices.GetById(id));
        }
    }
}
