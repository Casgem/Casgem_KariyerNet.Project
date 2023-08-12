using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System.ComponentModel.DataAnnotations.Schema;

namespace Casgem_DTOLayer.DTOs.Concrete.JobSeekerJobAdvertisementSearchHistoryDTOs
{
    public class SelectJobSeekerJobAdvertisementSearchHistoryDTO : ISelectDTO
    {
       
        public int JobSeekerJobAdvertisementSearchHistoryId { get; set; }
        public string Word { get; set; }
        //public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
