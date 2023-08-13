using Casgem_BusinessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationInformationController : ControllerBase
    {

        private readonly IEducationInformationService EducationInformationService;

        public EducationInformationController(IEducationInformationService EducationInformationService)
        {
            this.EducationInformationService = EducationInformationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = EducationInformationService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> Add(EducationInformation EducationInformation)
        {
            EducationInformationService.TInsert(EducationInformation);
            return Ok(EducationInformation);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = EducationInformationService.TGetByID(id);
            EducationInformationService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(EducationInformation EducationInformation)
        {
            EducationInformationService.TUpdate(EducationInformation);
            return Ok(EducationInformation);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var values = EducationInformationService.TGetByID(id);
            return Ok(values);
        }
    }
}

