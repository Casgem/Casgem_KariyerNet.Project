using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class EmployerJobAdvertisementSearchHistoryManager : IEmployerJobAdvertisementSearchHistoryService
    {
        private readonly IEmployerJobAdvertisementSearchHistoryDal _employerJobAdvertisementSearchHistoryDal;

        public EmployerJobAdvertisementSearchHistoryManager(IEmployerJobAdvertisementSearchHistoryDal employerJobAdvertisementSearchHistoryDal)
        {
            _employerJobAdvertisementSearchHistoryDal = employerJobAdvertisementSearchHistoryDal;
        }

        public void TDelete(EmployerJobAdvertisementSearchHistory t)
        {
            _employerJobAdvertisementSearchHistoryDal.Delete(t);
        }

        public EmployerJobAdvertisementSearchHistory TGetByID(int id)
        {
            return _employerJobAdvertisementSearchHistoryDal.GetByID(id);
        }

        public List<EmployerJobAdvertisementSearchHistory> TGetList()
        {
            return _employerJobAdvertisementSearchHistoryDal.GetList();
        }

        public void TInsert(EmployerJobAdvertisementSearchHistory t)
        {
            _employerJobAdvertisementSearchHistoryDal.Insert(t);
        }

        public void TUpdate(EmployerJobAdvertisementSearchHistory t)
        {
            _employerJobAdvertisementSearchHistoryDal.Update(t);
        }
    }
}
