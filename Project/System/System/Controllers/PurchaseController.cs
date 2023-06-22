using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Model.Dto;
using Server.Model.Entity;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/purchase")]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseServices _purchaseServices;
        private readonly IContractServices _contractServices;
        public PurchaseController(IPurchaseServices purchaseServices, IContractServices contractServices)
        {
            _purchaseServices = purchaseServices;
            _contractServices = contractServices;
        }
        [HttpGet]
        public IActionResult SupList()
        {
            List<Suppliers> data = _purchaseServices.GetSup();
            return Ok(data);
        }


        [HttpGet("{supid}")]
        public IActionResult GetItem(string supID)
        {
            List<GetPurItemDto> data = _purchaseServices.GetItem(supID);
            return Ok(data);
        }


        [HttpGet("bpa/{supid}")]
        public IActionResult GetBpaInfo(string supID)
        {
            List<BpaListDto> data = _contractServices.GetBpaInfo(supID);
            return Ok(data);
        }
    }
}
