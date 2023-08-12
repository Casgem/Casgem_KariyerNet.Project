using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.JobApplicationDTOs
{
    public class SelectJobApplicationDTO : ISelectDTO
    {
        public int JobApplicationId { get; set; }//iş başvurusu id'si.
        //public int JobAdvertisementId { get; set; } //İş ilanı Id hangi iş ilanına başvurulmuş?
        public JobAdvertisement JobAdvertisement { get; set; } //hangi iş ilanına başvurulmuş?
        //public int JobSeekerId { get; set; } //İş arayan Id
        //iş arayan ile iş ilanı 1'e çok ilişkili. 1 kişi birden fazla başvuru yapabilir.
        public JobSeeker JobSeeker { get; set; }
        //public int EmployerId { get; set; } //
        public Employer Employer { get; set; }
    }
}
