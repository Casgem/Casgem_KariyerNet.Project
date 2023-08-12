using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Repositories.Concrete;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Concrete.EntityFramework
{
    public class EfEducationInformationDal : GenericRepository<EducationInformation>, IEducationInformationDal
    {

    }
}
