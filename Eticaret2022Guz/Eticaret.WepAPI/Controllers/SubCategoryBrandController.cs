using ETicaret.BussinessLayer.Abstract;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryBrandController : ControllerBase
    {
        private readonly ISubCategoryBrandService _ISubCategoryBrandService;

        public SubCategoryBrandController(ISubCategoryBrandService ISubCategoryBrandService)
        {
            _ISubCategoryBrandService = ISubCategoryBrandService;
        }

        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetList()
        {
            var result = await _ISubCategoryBrandService.GetListAsync(x => x.SubCategoryBrandStatu == true);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ISubCategoryBrandService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] SubCategoryBrand subCategoryBrand)
        {
            var result = await _ISubCategoryBrandService.AddAsync(subCategoryBrand);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _ISubCategoryBrandService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetLast3()
        {
            var result = await _ISubCategoryBrandService.Get3SubCategoryBrandAsync();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] SubCategoryBrand subCategoryBrand)
        {
            var result = await _ISubCategoryBrandService.UpdateAsync(subCategoryBrand);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
