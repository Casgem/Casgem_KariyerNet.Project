using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_BusinessLayer.Abstract
{
    public interface IJobAdvertisementService : IGenericService<JobAdvertisement>
    {
        public JobAdvertisement GetJobAdvertisementWithWorkExperince(int id);
        public JobAdvertisement GetJobAdvertisementWithJobApplication(int id);
        public List<JobAdvertisement> GetJobAdvertisementWithJobApplications();
    }
}