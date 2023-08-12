using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobSeekerJobAdvertisementSearchHistoryDTOs
{
    public class UpdateJobSeekerJobAdvertisementSearchHistoryDTO : IDTO
    {
        public int JobSeekerJobAdvertisementSearchHistoryId { get; set; }
        public string Word { get; set; }
        //public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}