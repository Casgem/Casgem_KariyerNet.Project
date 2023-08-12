using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CurriculumVitaeDTOs
{
    public class UpdateCurriculumVitaeDTO : IDTO
    {
        public int CurriculumVitaeId { get; set; }
        public string CVName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LinkedinUrl { get; set; }
        public string ProfilePhotoUrl { get; set; }
        public string Nationality { get; set; }
        public string DriverLicence { get; set; }
        public string MilitaryStatus { get; set; }
        public bool DisabilityStatus { get; set; }
        public string SummaryInformation { get; set; }
        public string Abilities { get; set; }
        public int WorkExperienceId { get; set; }
        public WorkExperience WorkExperience { get; set; }
        public int EducationInformationId { get; set; }
        public EducationInformation EducationInformation { get; set; }
    }
}