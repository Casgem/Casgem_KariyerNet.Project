using Casgem_DataAccessLayer.Repositories.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Abstract
{
    public interface IJobAdvertisementDal : IGenericDal<JobAdvertisement>
    {
        public JobAdvertisement GetJobAdvertisementWithWorkExperince(int id);
        public JobAdvertisement GetJobAdvertisementWithJobApplication(int id);
        public List<JobAdvertisement> GetJobAdvertisementWithJobApplications();

        public void AddJobAdvertisementForJobApplications(int jobAdvertisementId, List<JobApplication> jobApplication);
        public void AddJobAdvertisementForJobApplication(int jobAdvertisementId, JobApplication jobApplication);
        public void AddJobAdvertisementForWorkExperince(int jobAdvertisementId, WorkExperience workExperince);

    }
}