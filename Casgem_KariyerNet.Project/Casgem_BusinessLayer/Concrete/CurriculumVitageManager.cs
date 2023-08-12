using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class CurriculumVitaeManager : ICurriculumVitaeService
    {
        private readonly ICurriculumVitaeDal _curriculumVitaeDal;

        public CurriculumVitaeManager(ICurriculumVitaeDal curriculumVitaeDal)
        {
            _curriculumVitaeDal = curriculumVitaeDal;
        }

        public CurriculumVitae GetCurriculumVitaeWithEducationInformation(int id)
        {
            return _curriculumVitaeDal.GetCurriculumVitaeWithEducationInformation(id);
        }

        public CurriculumVitae GetCurriculumVitaeWithWorkExperience(int id)
        {
            return _curriculumVitaeDal.GetCurriculumVitaeWithWorkExperience(id);
        }

        public void TDelete(CurriculumVitae t)
        {
            _curriculumVitaeDal.Delete(t);
        }

        public CurriculumVitae TGetByID(int id)
        {
            return _curriculumVitaeDal.GetByID(id);
        }

        public List<CurriculumVitae> TGetList()
        {
            return _curriculumVitaeDal.GetList();
        }

        public void TInsert(CurriculumVitae t)
        {
            _curriculumVitaeDal.Insert(t);
        }

        public void TUpdate(CurriculumVitae t)
        {
            _curriculumVitaeDal.Update(t);
        }
    }
}
