using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.DegreeDTOs
{
    public class SelectDegreeDTO : ISelectDTO
    {
        public int DegreeId { get; set; } //ünvan id
        public int CompanyId { get; set; } //şirket id'si. 1'e çok
        public Company Company { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
    }
}
