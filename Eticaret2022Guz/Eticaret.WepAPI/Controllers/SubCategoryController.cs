using ETicaret.BussinessLayer.Abstract;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _ISubCategoryService;

        public SubCategoryController(ISubCategoryService ISubCategoryService)
        {
            _ISubCategoryService = ISubCategoryService;
        }

        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetList()
        {
            var result = await _ISubCategoryService.GetListAsync(x => x.SubCategoryStatu == true);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ISubCategoryService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] SubCategory subCategory)
        {
            var result = await _ISubCategoryService.AddAsync(subCategory);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ISubCategoryService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetLast3()
        {
            var result = await _ISubCategoryService.Get3SubCategoryAsync();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] SubCategory subCategory)
        {
            var result = await _ISubCategoryService.UpdateAsync(subCategory);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
