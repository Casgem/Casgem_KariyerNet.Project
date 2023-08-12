using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş ilanı arama kısmı geçmişi Entity'si.
    public class JobSeekerJobAdvertisementSearchHistory : IEntity
    {
        [ForeignKey("JobSeeker")]
        public int JobSeekerJobAdvertisementSearchHistoryId { get; set; }
        public string Word { get; set; }
        public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}
