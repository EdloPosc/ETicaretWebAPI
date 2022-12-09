using ETicaret.BussinessLayer.Abstract;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _IBrandService;

        public BrandController(IBrandService IBrandService)
        {
            _IBrandService = IBrandService;
        }

        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetList()
        {
            var result = await _IBrandService.GetListAsync(x => x.BrandStatu == true);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _IBrandService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Brand brand)
        {
            var result = await _IBrandService.AddAsync(brand);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _IBrandService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetLast3()
        {
            var result = await _IBrandService.Get3BrandAsync();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] Brand brand)
        {
            var result = await _IBrandService.UpdateAsync(brand);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }
    }
}
