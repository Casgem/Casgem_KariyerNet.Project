using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CurriculumVitaeDTOs
{
    public class DeleteCurriculumVitaeDTO : IDTO
    {
        public int CurriculumVitaeId { get; set; }
    }
}
