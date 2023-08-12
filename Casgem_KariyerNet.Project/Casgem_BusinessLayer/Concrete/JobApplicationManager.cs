using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class JobApplicationManager : IJobApplicationService
    {
        private readonly IJobApplicationDal _jobApplicationDal;

        public JobApplicationManager(IJobApplicationDal jobApplicationDal)
        {
            _jobApplicationDal = jobApplicationDal;
        }

        public JobApplication GetJobApplicationWithEmployer(int id)
        {
            return _jobApplicationDal.GetJobApplicationWithEmployer(id);
        }

        public JobApplication GetJobApplicationWithJobAdvertisement(int id)
        {
            return _jobApplicationDal.GetJobApplicationWithJobAdvertisement(id);
        }

        public JobApplication GetJobApplicationWithJobSeeker(int id)
        {
            return _jobApplicationDal.GetJobApplicationWithJobSeeker(id);
        }

        public void TDelete(JobApplication t)
        {
            _jobApplicationDal.Delete(t);
        }

        public JobApplication TGetByID(int id)
        {
            return _jobApplicationDal.GetByID(id);
        }

        public List<JobApplication> TGetList()
        {
            return _jobApplicationDal.GetList();
        }

        public void TInsert(JobApplication t)
        {
            _jobApplicationDal.Insert(t);
        }

        public void TUpdate(JobApplication t)
        {
            _jobApplicationDal.Update(t);
        }
    }
}
