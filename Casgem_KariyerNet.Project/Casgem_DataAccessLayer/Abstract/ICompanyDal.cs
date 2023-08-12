using Casgem_DataAccessLayer.Repositories.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Abstract
{
    public interface ICompanyDal : IGenericDal<Company>
    {
        public Company GetCompanyWithDegree(int id);
        public List<Company> GetCompanyWithDegrees();
        public void AddCompanyForDegree(int companyId, Degree degree);
        public void AddCompanyForDegrees(int companyId, List<Degree> degrees);
    }
}