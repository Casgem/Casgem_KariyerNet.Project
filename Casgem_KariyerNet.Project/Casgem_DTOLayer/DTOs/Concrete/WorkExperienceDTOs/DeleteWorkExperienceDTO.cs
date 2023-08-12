using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.WorkExperienceDTOs
{
    public class DeleteWorkExperienceDTO : IDTO
    {
        public int WorkExperienceId { get; set; }
    }
}
