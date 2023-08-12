using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class JobSeekerJobAdvertisementSearchHistoryManager : IJobSeekerJobAdvertisementSearchHistoryService
    {
        private readonly IJobSeekerJobAdvertisementSearchHistoryDal _jobSeekerJobAdvertisementSearchHistoryDal;

        public JobSeekerJobAdvertisementSearchHistoryManager(IJobSeekerJobAdvertisementSearchHistoryDal jobSeekerJobAdvertisementSearchHistoryDal)
        {
            _jobSeekerJobAdvertisementSearchHistoryDal = jobSeekerJobAdvertisementSearchHistoryDal;
        }

        public void TDelete(JobSeekerJobAdvertisementSearchHistory t)
        {
            _jobSeekerJobAdvertisementSearchHistoryDal.Delete(t);
        }

        public JobSeekerJobAdvertisementSearchHistory TGetByID(int id)
        {
            return _jobSeekerJobAdvertisementSearchHistoryDal.GetByID(id);
        }

        public List<JobSeekerJobAdvertisementSearchHistory> TGetList()
        {
            return _jobSeekerJobAdvertisementSearchHistoryDal.GetList();
        }

        public void TInsert(JobSeekerJobAdvertisementSearchHistory t)
        {
            _jobSeekerJobAdvertisementSearchHistoryDal.Insert(t);
        }

        public void TUpdate(JobSeekerJobAdvertisementSearchHistory t)
        {
            _jobSeekerJobAdvertisementSearchHistoryDal.Update(t);
        }
    }
}