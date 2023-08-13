using Casgem_BusinessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {

        private readonly ICompanyService companyService;

        public CompanyController(ICompanyService companyService)
        {
            this.companyService = companyService;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var values = companyService.TGetList();
            return Ok(values);

        }

        [HttpPost]
        public async Task<IActionResult> Add(Company company)
        {
            companyService.TInsert(company);
            return Ok(company);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var value = companyService.TGetByID(id);
            companyService.TDelete(value);
            return Ok();
        }


        [HttpPut]
        public async Task<IActionResult> Edit(Company company)
        {
            companyService.TUpdate(company);
            return Ok(company);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var values = companyService.TGetByID(id);
            return Ok(values);
        }
    }
}

