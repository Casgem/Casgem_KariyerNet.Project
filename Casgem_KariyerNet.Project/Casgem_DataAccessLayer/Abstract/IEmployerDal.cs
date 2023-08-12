using Casgem_DataAccessLayer.Repositories.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Abstract
{
    public interface IEmployerDal : IGenericDal<Employer>
    {
        public Employer GetEmployerWithCompany(int id);
        public List<Employer> GetEmployerWithCompanies();

        public List<Employer> GetEmployerWithDegrees();
        public Employer GetEmployerWithDegree(int id);

        public List<Employer> GetEmployerWithJobAdvertisementSearchHistories();
        public Employer GetEmployerWithJobAdvertisementSearchHistory(int id);

        public List<Employer> GetEmployerWithJobAdvertisements();
        public Employer GetEmployerWithJobAdvertisement(int id);

        public void AddEmployerForDegree(int employerId, Degree degree);
        public void AddEmployerForDegrees(int employerId, List<Degree> degrees);
        public void AddEmployerForJobAdvertisementSearchHistory(int employerId, EmployerJobAdvertisementSearchHistory history);
        public void AddEmployerForJobAdvertisement(int employerId, JobAdvertisement jobAdvertisement);
    }
}