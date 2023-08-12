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
    public class EfJobAdvertisementDal : GenericRepository<JobAdvertisement>, IJobAdvertisementDal
    {
        private readonly KariyerNetDbContext _context;

        public EfJobAdvertisementDal(KariyerNetDbContext context)
        {
            _context = context;
        }

        public void AddJobAdvertisementForJobApplication(int jobAdvertisementId, JobApplication jobApplication)
        {
            var value = _context.JobAdvertisements.Include(jobAdvertisement => jobAdvertisement.JobApplication).Where(jobAdvertisement => jobAdvertisement.JobAdvertisementId == jobAdvertisementId).FirstOrDefault();
            value.JobApplication.Add(jobApplication);
            _context.SaveChanges();
        }

        public void AddJobAdvertisementForJobApplications(int jobAdvertisementId, List<JobApplication> jobApplication)
        {
            var value = _context.JobAdvertisements.Include(jobAdvertisement => jobAdvertisement.JobApplication).Where(jobAdvertisement => jobAdvertisement.JobAdvertisementId == jobAdvertisementId).FirstOrDefault();
            jobApplication.ForEach(jobApp => value.JobApplication.Add(jobApp));
        }

        public void AddJobAdvertisementForWorkExperince(int jobAdvertisementId, WorkExperience workExperince)
        {
            var value = _context.JobAdvertisements.Include(jobAdvertisement => jobAdvertisement.JobApplication).Where(jobAdvertisement => jobAdvertisement.JobAdvertisementId == jobAdvertisementId).FirstOrDefault();
            value.WorkExperience = workExperince;
            _context.SaveChanges();
        }

        public JobAdvertisement GetJobAdvertisementWithJobApplication(int id)
        {
            return _context.JobAdvertisements.Include(jobAdvertisement => jobAdvertisement.JobApplication).Where(jobAdvertisement => jobAdvertisement.JobAdvertisementId == id).FirstOrDefault();
        }

        public List<JobAdvertisement> GetJobAdvertisementWithJobApplications()
        {
            return _context.JobAdvertisements.Include(jobAdvertisement => jobAdvertisement.JobApplication).ToList();
        }

        public JobAdvertisement GetJobAdvertisementWithWorkExperince(int id)
        {
            return _context.JobAdvertisements.Include(jobAdvertisement => jobAdvertisement.WorkExperience).Where(jobAdvertisement => jobAdvertisement.JobAdvertisementId == id).FirstOrDefault();
        }
    }
}