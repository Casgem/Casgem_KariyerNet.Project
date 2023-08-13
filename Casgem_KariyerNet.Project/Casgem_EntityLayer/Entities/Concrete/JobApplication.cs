using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş ilanı başvurusu / Başvurular Entity'si.
    public class JobApplication : IEntity
    {
        public int JobApplicationId { get; set; }//iş başvurusu id'si.
        public int JobAdvertisementId { get; set; } //İş ilanı Id hangi iş ilanına başvurulmuş?
        public JobAdvertisement JobAdvertisement { get; set; } //hangi iş ilanına başvurulmuş?
       
        public int UserId { get; set; } //
        public User User { get; set; }
    }
}