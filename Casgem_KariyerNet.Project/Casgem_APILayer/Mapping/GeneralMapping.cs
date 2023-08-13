using AutoMapper;
using Casgem_DTOLayer.DTOs.Concrete.AppUserDTOs;
using Casgem_DTOLayer.DTOs.Concrete.CompanyDTOs;
using Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.CurriculumVitaeDTOs;
using Casgem_DTOLayer.DTOs.Concrete.DeleteJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.EducationInformationDTOs;
using Casgem_DTOLayer.DTOs.Concrete.EmployerDTOs;

using Casgem_DTOLayer.DTOs.Concrete.JobAdvertisementDTOs;
using Casgem_DTOLayer.DTOs.Concrete.JobApplicationDTOs;

using Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.UpdateJobSeekerDTOs;
using Casgem_DTOLayer.DTOs.Concrete.UserDTOs;
using Casgem_DTOLayer.DTOs.Concrete.WorkExperienceDTOs;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_APILayer.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<User, CreateUserDTO>().ReverseMap();
            CreateMap<User, SelectUserDTO>().ReverseMap();
            CreateMap<User, UpdateUserDTO>().ReverseMap();

            CreateMap<AppUser, CreateAppUserDTO>().ReverseMap();
            CreateMap<AppUser, SelectAppUserDTO>().ReverseMap();
            CreateMap<AppUser, UpdateAppUserDTO>().ReverseMap();
            CreateMap<AppUser, DeleteAppUserDTO>().ReverseMap();

            CreateMap<Company, CreateCompanyDTO>().ReverseMap();
            CreateMap<Company, SelectCompanyDTO>().ReverseMap();
            CreateMap<Company, UpdateCompanyDTO>().ReverseMap();
            CreateMap<Company, DeleteCompanyDTO>().ReverseMap();

            CreateMap<CurriculumVitae, CreateCurriculumVitaeDTO>().ReverseMap();
            CreateMap<CurriculumVitae, SelectCurriculumVitaeDTO>().ReverseMap();
            CreateMap<CurriculumVitae, UpdateCurriculumVitaeDTO>().ReverseMap();
            CreateMap<CurriculumVitae, DeleteCurriculumVitaeDTO>().ReverseMap();

            CreateMap<EducationInformation, CreateEducationInformationDTO>().ReverseMap();
            CreateMap<EducationInformation, SelectEducationInformationDTO>().ReverseMap();
            CreateMap<EducationInformation, UpdateEducationInformationDTO>().ReverseMap();
            CreateMap<EducationInformation, DeleteEducationInformationDTO>().ReverseMap();

            //CreateMap<EmployerJobAdvertisementSearchHistory, CreateEmployerJobAdvertisementSearchHistoryDTO>().ReverseMap();
            //CreateMap<EmployerJobAdvertisementSearchHistory, SelectEmployerJobAdvertisementSearchHistoryDTO>().ReverseMap();
            //CreateMap<EmployerJobAdvertisementSearchHistory, UpdateEmployerJobAdvertisementSearchHistoryDTO>().ReverseMap();
            //CreateMap<EmployerJobAdvertisementSearchHistory, DeleteEmployerJobAdvertisementSearchHistoryDTO>().ReverseMap();


            CreateMap<JobAdvertisement, CreateJobAdvertisementDTO>().ReverseMap();
            CreateMap<JobAdvertisement, SelectJobAdvertisementDTO>().ReverseMap();
            CreateMap<JobAdvertisement, UpdateJobAdvertisementDTO>().ReverseMap();
            CreateMap<JobAdvertisement, DeleteJobAdvertisementDTO>().ReverseMap();

            CreateMap<JobApplication, CreateJobApplicationDTO>().ReverseMap();
            CreateMap<JobApplication, SelectJobApplicationDTO>().ReverseMap();
            CreateMap<JobApplication, UpdateJobApplicationDTO>().ReverseMap();
            CreateMap<JobApplication, DeleteJobApplicationDTO>().ReverseMap();

            //CreateMap<JobSeekerJobAdvertisementSearchHistory, CreateJobSeekerJobAdvertisementSearchHistoryDTO>().ReverseMap();
            //CreateMap<JobSeekerJobAdvertisementSearchHistory, SelectJobSeekerJobAdvertisementSearchHistoryDTO>().ReverseMap();
            //CreateMap<JobSeekerJobAdvertisementSearchHistory, UpdateJobSeekerJobAdvertisementSearchHistoryDTO>().ReverseMap();
            //CreateMap<JobSeekerJobAdvertisementSearchHistory, DeleteJobSeekerJobAdvertisementSearchHistoryDTO>().ReverseMap();

            CreateMap<WorkExperience, CreateWorkExperienceDTO>().ReverseMap();
            CreateMap<WorkExperience, SelectWorkExperienceDTO>().ReverseMap();
            CreateMap<WorkExperience, UpdateWorkExperienceDTO>().ReverseMap();
            CreateMap<WorkExperience, DeleteWorkExperienceDTO>().ReverseMap();
        }
    }
}
