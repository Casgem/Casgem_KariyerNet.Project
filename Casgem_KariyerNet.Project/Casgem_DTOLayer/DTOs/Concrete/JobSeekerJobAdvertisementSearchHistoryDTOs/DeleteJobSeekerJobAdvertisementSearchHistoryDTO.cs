using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace Casgem_DTOLayer.DTOs.Concrete.JobSeekerJobAdvertisementSearchHistoryDTOs
{
    public class DeleteJobSeekerJobAdvertisementSearchHistoryDTO : IDTO
    {
        
        public int JobSeekerJobAdvertisementSearchHistoryId { get; set; }
    }
}
