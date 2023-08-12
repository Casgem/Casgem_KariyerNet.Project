using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_BusinessLayer.Abstract
{
    public interface IEmployerService : IGenericService<Employer>
    {
        public Employer GetEmployerWithCompany(int id);
        public List<Employer> GetEmployerWithCompanies();

        public List<Employer> GetEmployerWithDegrees();
        public Employer GetEmployerWithDegree(int id);

        public List<Employer> GetEmployerWithJobAdvertisementSearchHistories();
        public Employer GetEmployerWithJobAdvertisementSearchHistory(int id);

        public List<Employer> GetEmployerWithJobAdvertisements();
        public Employer GetEmployerWithJobAdvertisement(int id);
    }
}