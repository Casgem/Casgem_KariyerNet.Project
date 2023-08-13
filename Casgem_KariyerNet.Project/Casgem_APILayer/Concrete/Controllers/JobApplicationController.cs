using Casgem_BusinessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationController : ControllerBase
    {

        private readonly IJobApplicationService JobApplicationService;

        public JobApplicationController(IJobApplicationService JobApplicationService)
        {
            this.JobApplicationService = JobApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = JobApplicationService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> Add(JobApplication JobApplication)
        {
            JobApplicationService.TInsert(JobApplication);
            return Ok(JobApplication);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = JobApplicationService.TGetByID(id);
            JobApplicationService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(JobApplication JobApplication)
        {
            JobApplicationService.TUpdate(JobApplication);
            return Ok(JobApplication);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var values = JobApplicationService.TGetByID(id);
            return Ok(values);
        }
    }
}

