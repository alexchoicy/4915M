using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/Supplier")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierServices _supplierServices;

        public SupplierController(ISupplierServices supplierServices)
        {
            _supplierServices = supplierServices;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {

            var data = _supplierServices.getAll();

            return Ok(data);
        }



    }
}