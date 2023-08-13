using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.Context;
using Casgem_DataAccessLayer.Repositories.Concrete;
using Casgem_EntityLayer.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Concrete.EntityFramework
{
    public class EfCompanyDal : GenericRepository<Company>, ICompanyDal
    {
        private readonly KariyerNetDbContext _context;

        public EfCompanyDal(KariyerNetDbContext context)
        {
            _context = context;
        }

    }
}
