using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.DegreeDTOs
{
    public class DeleteDegreeDTO : IDTO
    {
        public int DegreeId { get; set; } //ünvan id
    }
}
