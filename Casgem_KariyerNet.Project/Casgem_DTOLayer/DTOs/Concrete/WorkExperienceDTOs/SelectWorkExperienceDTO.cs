using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.WorkExperienceDTOs
{
    public class SelectWorkExperienceDTO : ISelectDTO
    {
        public int WorkExperienceId { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobAdvertisementId { get; set; }
        public JobAdvertisement JobAdvertisement { get; set; }
    }
}
