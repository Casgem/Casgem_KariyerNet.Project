using Casgem_EntityLayer.Entities.Abstract;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public string NameSurname { get; set; }

        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
        public int JobSeekerId { get; set; }
        public JobSeeker JobSeeker { get; set; }
    }
}