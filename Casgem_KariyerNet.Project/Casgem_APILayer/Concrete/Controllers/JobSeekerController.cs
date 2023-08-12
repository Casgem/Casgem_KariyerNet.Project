using AutoMapper;
using Casgem_APILayer.Abstract;
using Casgem_BusinessLayer.Abstract;
using Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.DegreeDTOs;
using Casgem_DTOLayer.DTOs.Concrete.DeleteJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.EducationInformationDTOs;
using Casgem_DTOLayer.DTOs.Concrete.JobApplicationDTOs;
using Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.UpdateJobSeekerDTOs;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_APILayer.Concrete.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobSeekerController : ControllerBase, IJobSeekerController
    {
        private readonly IJobSeekerService _jobSeekerService;
        private readonly IMapper _mapper;

        public JobSeekerController(IJobSeekerService jobSeekerService, IMapper mapper)
        {
            _jobSeekerService = jobSeekerService;
            _mapper = mapper;
        }

        [HttpPost("/AddJobSeeker")]
        public async Task<IActionResult> AddJobSeeker(CreateJobSeekerDTO createJobSeekerDTO)
        {
            if (HttpContext.Session.GetString("username") != null)
            {
                var value = _mapper.Map<JobSeeker>(createJobSeekerDTO);
                _jobSeekerService.TInsert(value);
                return Ok(value);
            }
            return BadRequest("Login olmadığınız için kayıt işlemi yapılamadı.");
        }

        [HttpPost("/AddJobSeekerForDegree")]
        public async Task<IActionResult> AddJobSeekerForDegree(int jobSeekerId, CreateDegreeDTO createDegreeDTO)
        {
            var value = _mapper.Map<Degree>(createDegreeDTO);
            _jobSeekerService.AddJobSeekerForDegree(jobSeekerId, value);
            return Ok(value);
        }

        [HttpPost("/AddJobSeekerForDegrees")]
        public async Task<IActionResult> AddJobSeekerForDegrees(int jobSeekerId, List<CreateDegreeDTO> createDegreeDTOs)
        {
            var value = _mapper.Map<List<Degree>>(createDegreeDTOs);
            _jobSeekerService.AddJobSeekerForDegrees(jobSeekerId, value);
            return Ok(value);
        }

        [HttpPost("/AddJobSeekerForEducationInformation")]
        public async Task<IActionResult> AddJobSeekerForEducationInformation(int jobSeekerId, CreateEducationInformationDTO createEducationInformationDTO)
        {
            var value = _mapper.Map<EducationInformation>(createEducationInformationDTO);
            _jobSeekerService.AddJobSeekerForEducationInformation(jobSeekerId, value);
            return Ok(value);
        }

        [HttpPost("/AddJobSeekerForJobApplication")]
        public async Task<IActionResult> AddJobSeekerForJobApplication(int jobSeekerId, CreateJobApplicationDTO createJobApplicationDTO)
        {
            var value = _mapper.Map<JobApplication>(createJobApplicationDTO);
            _jobSeekerService.AddJobSeekerForJobApplication(jobSeekerId, value);
            return Ok(value);
        }

        [HttpPost("/AddJobSeekerForJobApplications")]
        public async Task<IActionResult> AddJobSeekerForJobApplications(int jobSeekerId, List<CreateJobApplicationDTO> createJobApplicationDTOs)
        {
            var value = _mapper.Map<List<JobApplication>>(createJobApplicationDTOs);
            _jobSeekerService.AddJobSeekerForJobApplication(jobSeekerId, value);
            return Ok(value);
        }

        [HttpPost("/DeleteJobSeeker")]
        public async Task<IActionResult> DeleteJobSeeker(DeleteJobSeekerDTO deleteJobSeekerDTO)
        {
            var value = _mapper.Map<JobSeeker>(deleteJobSeekerDTO);
            _jobSeekerService.TDelete(value);
            return Ok(value);
        }

        [HttpGet("/GetJobSeeker")]
        public async Task<IActionResult> GetJobSeeker(SelectJobSeekerDTO selectJobSeekerDTO)
        {
            return Ok(_jobSeekerService.TGetList());
        }

        [HttpGet("/GetJobSeekerWithDegree")]
        public async Task<IActionResult> GetJobSeekerWithDegree()
        {
            return Ok(_jobSeekerService.GetJobSeekerWithDegree());
        }

        [HttpGet("/GetJobSeekerByIdWithDegree")]
        public async Task<IActionResult> GetJobSeekerWithDegree(int id)
        {
            return Ok(_jobSeekerService.GetJobSeekerWithDegree(id));
        }

        [HttpGet("/GetJobSeekerWithEducationInformation")]
        public async Task<IActionResult> GetJobSeekerWithEducationInformation(int id)
        {
            return Ok(_jobSeekerService.GetJobSeekerWithEducationInformation(id));
        }

        [HttpGet("/GetJobSeekerWithJobApplication")]
        public async Task<IActionResult> GetJobSeekerWithJobApplication()
        {
            return Ok(_jobSeekerService.GetJobSeekerWithJobApplication());
        }

        [HttpGet("/GetJobSeekerByIdWithJobApplication")]
        public async Task<IActionResult> GetJobSeekerWithJobApplication(int id)
        {
            return Ok(_jobSeekerService.GetJobSeekerWithJobApplication(id));
        }

        [HttpPut("/UpdateJobSeeker")]
        public async Task<IActionResult> UpdateJobSeeker(UpdateJobSeekerDTO createJobSeekerDTO)
        {
            var value = _mapper.Map<JobSeeker>(createJobSeekerDTO);
            _jobSeekerService.TUpdate(value);
            return Ok(value);
        }
    }
}
