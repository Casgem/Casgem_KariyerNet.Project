using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CreateJobSeekerDTOs
{
    public class CreateJobSeekerDTO : IDTO
    {
        public int AppUserId { get; set; } //bir iş arayan üye olan kullanıcı ile 1'e 1 ilişkili.
        //public AppUser AppUser { get; set; } //bir iş arayan üye olan kullanıcı ile 1'e 1 ilişkili.
        //public List<Degree> Degrees { get; set; }
        public int DegreeId { get; set; }
        public List<Degree> Degrees { get; set; }
        public int EducationInformationId { get; set; }
        public EducationInformation EducationInformation { get; set; }
    }
}