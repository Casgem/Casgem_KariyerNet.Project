using Casgem_DataAccessLayer.Concrete.Context;
using Casgem_DataAccessLayer.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Repositories.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var context = new KariyerNetDbContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
            using var context = new KariyerNetDbContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var context = new KariyerNetDbContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new KariyerNetDbContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new KariyerNetDbContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}