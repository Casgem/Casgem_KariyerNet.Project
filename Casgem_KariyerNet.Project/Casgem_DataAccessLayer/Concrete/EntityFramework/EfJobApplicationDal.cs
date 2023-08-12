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
    public class EfJobApplicationDal : GenericRepository<JobApplication>, IJobApplicationDal
    {
        private readonly KariyerNetDbContext _context;

        public EfJobApplicationDal(KariyerNetDbContext context)
        {
            _context = context;
        }

        public JobApplication GetJobApplicationWithEmployer(int id)
        {
            return _context.JobApplications.Include(jobApplication => jobApplication.Employer).Where(jobApplication => jobApplication.JobApplicationId == id).FirstOrDefault();
        }

        public JobApplication GetJobApplicationWithJobAdvertisement(int id)
        {
            return _context.JobApplications.Include(jobApplication => jobApplication.JobAdvertisement).Where(jobApplication => jobApplication.JobApplicationId == id).FirstOrDefault();
        }

        public JobApplication GetJobApplicationWithJobSeeker(int id)
        {
            return _context.JobApplications.Include(jobApplication => jobApplication.JobSeeker).Where(jobApplication => jobApplication.JobApplicationId == id).FirstOrDefault();
        }
    }
}