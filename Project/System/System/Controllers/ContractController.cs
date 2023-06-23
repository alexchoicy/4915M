using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Controllers.Input;
using Server.Services;

namespace Server.Controllers
{

    [ApiController]
    [Authorize]
    [Route("api/contract")]
    public class ContractController : ControllerBase
    {
        private readonly IContractServices _ContractServices;
        public ContractController(IContractServices ContractServices)
        {
            _ContractServices = ContractServices;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var cate = _ContractServices.GetAll();
            return Ok(cate);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {
            var items = _ContractServices.GetById(id);
            return Ok(items);
        }

        [HttpGet("{id}/Docs")]
        public IActionResult GetDocs(string id)
        {
            var folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docs", "Contract");
            var filePath = Path.Combine(folderPath, id + ".pdf");
            Console.WriteLine(filePath);
            if (System.IO.File.Exists(filePath))
            {
                return File(System.IO.File.OpenRead(filePath), "application/pdf");

            }
            return NotFound();
        }

        [HttpGet("bySupplier/{id}")]
        public IActionResult GetBySupplier(string id)
        {
            var items = _ContractServices.GetBySupplier(id);
            return Ok(items);
        }

        [HttpGet("getBPA/Docs/{BPAid}")]
        public IActionResult GetBPADocs(string BPAid)
        {
            string id = _ContractServices.getConIDByBPA(BPAid);
            var folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Docs", "Contract");
            var filePath = Path.Combine(folderPath, id + ".pdf");
            Console.WriteLine(filePath);
            if (System.IO.File.Exists(filePath))
            {
                return File(System.IO.File.OpenRead(filePath), "application/pdf");

            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult MakeNewRec([FromForm] MakeNewContractModel data)
        {
            _ContractServices.MakeNewRec(data);
            return Ok();
        }
    }
}
