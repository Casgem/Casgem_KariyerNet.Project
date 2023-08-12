using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EmployerJobAdvertisementSearchHistoryDTOs
{
    public class UpdateEmployerJobAdvertisementSearchHistoryDTO : IDTO
    {
        public int EmployerJobAdvertisementSearchHistoryId { get; set; }
        public string Word { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
    }
}