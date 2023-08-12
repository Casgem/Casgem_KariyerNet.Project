using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EmployerDTOs
{
    public class DeleteEmployerDTO : IDTO
    {
        public int EmployerId { get; set; }
    }
}
