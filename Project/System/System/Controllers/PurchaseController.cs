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
        [HttpGet("bpa/new/{supid}")]
        public IActionResult GetNewBpaID(string supID)
        {
            string data = _purchaseServices.getLastID(supID);
            return Ok(data);
        }

        [HttpPost]
        public IActionResult MakeNewPurchase([FromForm] PuchaseNewModel data)
        {
            bool status = _purchaseServices.MakeNewPurchase(data);
            if (status)
            {
                return Ok();
            }
            return BadRequest();
        }

        //History
        [HttpGet("record")]
        public IActionResult getRecord()
        {
            List<PurchaseRecord> data = _purchaseServices.getRecord();
            return Ok(data);
        }

        [HttpGet("record/{pid}")]
        public IActionResult getRecordItem(string pid)
        {
            History data = _purchaseServices.getRecordItem(pid);
            return Ok(data);
        }

        [HttpGet("record/{pid}/Docs")]
        public IActionResult GetDocs(string pid)
        {
            var folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docs", "Purchase");
            var filePath = Path.Combine(folderPath, pid + ".pdf");
            Console.WriteLine(filePath);
            if (System.IO.File.Exists(filePath))
            {
                return File(System.IO.File.OpenRead(filePath), "application/pdf");

            }
            return NotFound();
        }

        [HttpPost("spo")]
        public IActionResult getSpoData([FromBody] List<reqspoModel> itemId)
        {
            List<SpoListDto> data = _purchaseServices.getSpoData(itemId);
            return Ok(data);
        }

    }
}
