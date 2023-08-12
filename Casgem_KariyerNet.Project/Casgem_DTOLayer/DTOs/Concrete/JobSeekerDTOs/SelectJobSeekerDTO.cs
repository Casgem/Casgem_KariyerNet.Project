using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.SelectJobSeekerDTOs
{
    public class SelectJobSeekerDTO : ISelectDTO
    {
        public int JobSeekerId { get; set; } //İş arayan Id
        public int CurriculumVitaeId { get; set; }//iş arayanın CV Id'si
        public CurriculumVitae CurriculumVitae { get; set; } //bir iş arayanın bir tane CV'si var bizim projemizde.
        public int AppUserId { get; set; } //bir iş arayan üye olan kullanıcı ile 1'e 1 ilişkili.
        public AppUser AppUser { get; set; } //bir iş arayan üye olan kullanıcı ile 1'e 1 ilişkili.
        //public int JobApplicationId { get; set; }
        public List<JobApplication> JobApplications { get; set; }
        //public int DegreeId { get; set; } //bir çalışanın birden fazla ünvanı olabilir.
        public List<Degree> Degrees { get; set; }
        //public int EducationInformationId { get; set; }
        public EducationInformation EducationInformation { get; set; }
        //public int JobSeekerJobAdvertisementSearchHistoryId { get; set; }
        public List<JobSeekerJobAdvertisementSearchHistory> JobSeekerJobAdvertisementSearchHistories { get; set; }
    }
}
