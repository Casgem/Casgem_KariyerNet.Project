using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_BusinessLayer.Abstract
{
    public interface ICompanyService : IGenericService<Company>
    {
        public Company GetCompanyWithDegree(int id);
        public List<Company> GetCompanyWithDegrees();
    }
}
