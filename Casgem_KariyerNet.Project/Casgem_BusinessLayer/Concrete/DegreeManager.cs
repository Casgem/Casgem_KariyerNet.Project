using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_BusinessLayer.Concrete
{
    public class DegreeManager : IDegreeService
    {
        private readonly IDegreeDal _degreeDal;

        public DegreeManager(IDegreeDal degreeDal)
        {
            _degreeDal = degreeDal;
        }

        public void TDelete(Degree t)
        {
            _degreeDal.Delete(t);
        }

        public Degree TGetByID(int id)
        {
            return _degreeDal.GetByID(id);
        }

        public List<Degree> TGetList()
        {
            return _degreeDal.GetList();
        }

        public void TInsert(Degree t)
        {
            _degreeDal.Insert(t);
        }

        public void TUpdate(Degree t)
        {
            _degreeDal.Update(t);
        }
    }
}
