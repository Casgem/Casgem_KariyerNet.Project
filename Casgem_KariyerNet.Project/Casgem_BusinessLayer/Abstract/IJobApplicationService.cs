using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_BusinessLayer.Abstract
{
    public interface IJobApplicationService : IGenericService<JobApplication>
    {
        public JobApplication GetJobApplicationWithJobAdvertisement(int id);
        public JobApplication GetJobApplicationWithJobSeeker(int id);
        public JobApplication GetJobApplicationWithEmployer(int id);
    }
}