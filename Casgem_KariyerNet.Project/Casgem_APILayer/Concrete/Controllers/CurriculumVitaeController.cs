using Casgem_BusinessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumVitaeController : ControllerBase
    {

        private readonly ICurriculumVitaeService CurriculumVitaeService;

        public CurriculumVitaeController(ICurriculumVitaeService CurriculumVitaeService)
        {
            this.CurriculumVitaeService = CurriculumVitaeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = CurriculumVitaeService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> Add(CurriculumVitae CurriculumVitae)
        {
            CurriculumVitaeService.TInsert(CurriculumVitae);
            return Ok(CurriculumVitae);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = CurriculumVitaeService.TGetByID(id);
            CurriculumVitaeService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(CurriculumVitae CurriculumVitae)
        {
            CurriculumVitaeService.TUpdate(CurriculumVitae);
            return Ok(CurriculumVitae);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var values = CurriculumVitaeService.TGetByID(id);
            return Ok(values);
        }
    }
}

