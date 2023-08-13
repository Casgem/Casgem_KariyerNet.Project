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
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        private readonly KariyerNetDbContext _context;

        public EfUserDal(KariyerNetDbContext context)
        {
            _context = context;
        }
        public void AddUserForEducationInformation(int UserId, EducationInformation educationInformation)
        {
            var value = _context.Users.Where(User => User.UserId == UserId).FirstOrDefault();
            value.EducationInformation = educationInformation;
            _context.SaveChanges();
        }

        public void AddUserForJobApplication(int UserId, JobApplication jobApplication)
        {
            var value = _context.Users.Where(User => User.UserId == UserId).FirstOrDefault();
            value.JobApplications.Add(jobApplication);
            _context.SaveChanges();
        }

        public void AddUserForJobApplication(int UserId, List<JobApplication> jobApplications)
        {
            var value = _context.Users.Where(User => User.UserId == UserId).FirstOrDefault();
            jobApplications.ForEach(jobApplication => value.JobApplications.Add(jobApplication));
            _context.SaveChanges();
        }

        public User GetUserWithEducationInformation(int id)
        {
            return _context.Users.Include(User => User.EducationInformation).Where(User => User.UserId == id).FirstOrDefault();
        }

        public List<User> GetUserWithJobApplication()
        {
            return _context.Users.Include(User => User.JobApplications).ToList();
        }

        //aslında WHERE Condition'u olan INNER JOIN
        public User GetUserWithJobApplication(int id)
        {
            return _context.Users.Include(User => User.JobApplications).Where(User => User.UserId == id).FirstOrDefault();
        }


        public List<User> GetUserWithJobAdvertisements()
        {
            return _context.Users.Include(User => User.JobAdvertisements).ToList();
        }

        public User GetUserWithJobAdvertisement(int id)
        {
            return _context.Users.Include(User => User.JobAdvertisements).Where(User => User.UserId == id).FirstOrDefault();
        }

        //public User GetUserWithCompany(int id)
        //{
        //    return _context.Users.Include(User => User.Companies).Where(User => User.UserId == id).FirstOrDefault();
        //}

        //public List<User> GetUserWithCompanies()
        //{
        //    return _context.Users.Include(User => User.Companies).ToList();
        //}

        public void AddUserForJobAdvertisement(int UserId, JobAdvertisement jobAdvertisement)
        {
            var value = _context.Users.Where(e => e.UserId == UserId).FirstOrDefault();
            value.JobAdvertisements.Add(jobAdvertisement);
            _context.SaveChanges();
        }

    }
}
