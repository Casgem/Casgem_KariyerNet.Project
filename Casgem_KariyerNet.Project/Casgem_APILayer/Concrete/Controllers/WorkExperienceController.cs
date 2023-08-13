using Casgem_BusinessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperienceController : ControllerBase
    {

        private readonly IWorkExperienceService WorkExperienceService;

        public WorkExperienceController(IWorkExperienceService WorkExperienceService)
        {
            this.WorkExperienceService = WorkExperienceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = WorkExperienceService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> Add(WorkExperience WorkExperience)
        {
            WorkExperienceService.TInsert(WorkExperience);
            return Ok(WorkExperience);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = WorkExperienceService.TGetByID(id);
            WorkExperienceService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(WorkExperience WorkExperience)
        {
            WorkExperienceService.TUpdate(WorkExperience);
            return Ok(WorkExperience);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var values = WorkExperienceService.TGetByID(id);
            return Ok(values);
        }
    }
}

