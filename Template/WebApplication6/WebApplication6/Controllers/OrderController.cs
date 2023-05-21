using Microsoft.AspNetCore.Mvc;
using WebApplication6.Services;

namespace WebApplication6.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderServices _memberServices;

        public OrderController(IOrderServices memberServices)
        {
            _memberServices = memberServices;
        }
        [HttpGet]
        public IActionResult GetAll(){
            return Ok(_memberServices.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_memberServices.GetById(id));
        }
    }
}
