using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.DeleteJobSeekerDTOs
{
    public class DeleteJobSeekerDTO : IDTO
    {
        public int JobSeekerId { get; set; } //İş arayan Id
       
    }
}
