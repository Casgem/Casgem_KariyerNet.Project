using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    public class WorkExperience : IEntity
    {
        public int WorkExperienceId { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int JobAdvertisementId { get; set; }
        public JobAdvertisement JobAdvertisement { get; set; }
    }
}