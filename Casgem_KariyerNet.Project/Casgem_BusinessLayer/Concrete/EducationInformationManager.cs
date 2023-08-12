using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class EducationInformationManager : IEducationInformationService
    {
        private readonly IEducationInformationDal _educationInformationManagerDal;

        public EducationInformationManager(IEducationInformationDal educationInformationDal)
        {
            _educationInformationManagerDal = educationInformationDal;
        }

        public void TDelete(EducationInformation t)
        {
            _educationInformationManagerDal.Delete(t);
        }

        public EducationInformation TGetByID(int id)
        {
            return _educationInformationManagerDal.GetByID(id);
        }

        public List<EducationInformation> TGetList()
        {
            return _educationInformationManagerDal.GetList();
        }

        public void TInsert(EducationInformation t)
        {
            _educationInformationManagerDal.Insert(t);
        }

        public void TUpdate(EducationInformation t)
        {
            _educationInformationManagerDal.Update(t);
        }
    }
}