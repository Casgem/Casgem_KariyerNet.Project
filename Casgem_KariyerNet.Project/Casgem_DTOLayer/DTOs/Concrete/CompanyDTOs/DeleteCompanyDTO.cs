using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CompanyDTOs
{
    public class DeleteCompanyDTO : IDTO
    {
        public int CompanyId { get; set; }
    }
}
