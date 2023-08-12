using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobAdvertisementDTOs
{
    public class DeleteJobAdvertisementDTO : IDTO
    {
        public int JobAdvertisementId { get; set; } //İş ilanı Id
    }
}
