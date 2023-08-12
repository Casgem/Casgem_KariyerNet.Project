using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EducationInformationDTOs
{
    public class DeleteEducationInformationDTO : IDTO
    {
        public int EducationInformationId { get; set; }
    }
}
