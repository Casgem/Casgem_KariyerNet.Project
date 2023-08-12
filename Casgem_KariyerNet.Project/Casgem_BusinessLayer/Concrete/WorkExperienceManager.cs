using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class WorkExperienceManager : IWorkExperienceService
    {
        private readonly IWorkExperienceDal _workExperienceDal;

        public WorkExperienceManager(IWorkExperienceDal workExperienceDal)
        {
            _workExperienceDal = workExperienceDal;
        }

        public void TDelete(WorkExperience t)
        {
            _workExperienceDal.Delete(t);
        }

        public WorkExperience TGetByID(int id)
        {
            return _workExperienceDal.GetByID(id);
        }

        public List<WorkExperience> TGetList()
        {
            return _workExperienceDal.GetList();
        }

        public void TInsert(WorkExperience t)
        {
            _workExperienceDal.Insert(t);
        }

        public void TUpdate(WorkExperience t)
        {
            _workExperienceDal.Update(t);
        }
    }
}