using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public Company GetCompanyWithDegree(int id)
        {
            return _companyDal.GetCompanyWithDegree(id);
        }

        public List<Company> GetCompanyWithDegrees()
        {
            return _companyDal.GetCompanyWithDegrees();
        }

        public void TDelete(Company t)
        {
            _companyDal.Delete(t);
        }

        public Company TGetByID(int id)
        {
            return _companyDal.GetByID(id);
        }

        public List<Company> TGetList()
        {
            return _companyDal.GetList();
        }

        public void TInsert(Company t)
        {
            _companyDal.Insert(t);
        }

        public void TUpdate(Company t)
        {
            _companyDal.Update(t);
        }
    }
}
