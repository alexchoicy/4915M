using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Model.Dto;
using Server.Model.Entity;
using Server.Services;

namespace Server.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/Category")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var cate = _categoryServices.GetAll();
            return Ok(cate);
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(string id)
        {

            var items = _categoryServices.GetByID(id);
            return Ok(items);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            _ = _categoryServices.CreateCate(category);
            return Ok();
        }


        [HttpPut]
        public IActionResult Edit([FromBody] Category category)
        {
            _ = _categoryServices.EditCate(category);
            return Ok();
        }

    }
}
