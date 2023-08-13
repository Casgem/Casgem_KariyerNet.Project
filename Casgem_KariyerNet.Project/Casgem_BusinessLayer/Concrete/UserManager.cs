using Casgem_BusinessLayer.Abstract;
using Casgem_DataAccessLayer.Abstract;
using Casgem_DataAccessLayer.Concrete.EntityFramework;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        //public List<User> GetUserWithCompanies()
        //{
        //    return _userDal.GetUserWithCompanies();
        //}

        //public User GetUserWithCompany(int id)
        //{
        //    return _userDal.GetUserWithCompany(id);
        //}

        public User GetUserWithJobAdvertisement(int id)
        {
            return _userDal.GetUserWithJobAdvertisement(id);
        }

        public List<User> GetUserWithJobAdvertisements()
        {
            return _userDal.GetUserWithJobAdvertisements();
        }

        public void AddUserForEducationInformation(int UserId, EducationInformation educationInformation)
        {
            _userDal.AddUserForEducationInformation(UserId, educationInformation);
        }

        public void AddUserForJobApplication(int UserId, JobApplication jobApplication)
        {
            _userDal.AddUserForJobApplication(UserId, jobApplication);
        }

        public void AddUserForJobApplication(int UserId, List<JobApplication> jobApplications)
        {
            _userDal.AddUserForJobApplication(UserId, jobApplications);
        }

        public User GetUserWithEducationInformation(int id)
        {
            return _userDal.GetUserWithEducationInformation(id);
        }

        public List<User> GetUserWithJobApplication()
        {
            return _userDal.GetUserWithJobApplication();
        }

        public User GetUserWithJobApplication(int id)
        {
            return _userDal.GetUserWithJobApplication(id);
        }


        public void TDelete(User t)
        {
            _userDal.Delete(t);
        }

        public User TGetByID(int id)
        {
            return _userDal.GetByID(id);
        }

        public List<User> TGetList()
        {
            return _userDal.GetList();
        }

        public void TInsert(User t)
        {
            _userDal.Insert(t);
        }

        public void TUpdate(User t)
        {
            _userDal.Update(t);
        }
    }
}
