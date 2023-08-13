using Casgem_DataAccessLayer.Repositories.Abstract;
using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_DataAccessLayer.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        public List<User> GetUserWithJobApplication();
        public User GetUserWithJobApplication(int id);

        public User GetUserWithEducationInformation(int id);
        public void AddUserForJobApplication(int UserId, JobApplication jobApplication);
        public void AddUserForJobApplication(int UserId, List<JobApplication> jobApplications);
        public void AddUserForEducationInformation(int UserId, EducationInformation educationInformation);
        //public User GetUserWithCompany(int id);
        //public List<User> GetUserWithCompanies();

        public List<User> GetUserWithJobAdvertisements();
        public User GetUserWithJobAdvertisement(int id);

        public void AddUserForJobAdvertisement(int UserId, JobAdvertisement jobAdvertisement);
    }
}
