using Casgem_BusinessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobAdvertisementController : ControllerBase
    {

        private readonly IJobAdvertisementService JobAdvertisementService;

        public JobAdvertisementController(IJobAdvertisementService JobAdvertisementService)
        {
            this.JobAdvertisementService = JobAdvertisementService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = JobAdvertisementService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> Add(JobAdvertisement JobAdvertisement)
        {
            JobAdvertisementService.TInsert(JobAdvertisement);
            return Ok(JobAdvertisement);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = JobAdvertisementService.TGetByID(id);
            JobAdvertisementService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(JobAdvertisement JobAdvertisement)
        {
            JobAdvertisementService.TUpdate(JobAdvertisement);
            return Ok(JobAdvertisement);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var values = JobAdvertisementService.TGetByID(id);
            return Ok(values);
        }
    }
}

