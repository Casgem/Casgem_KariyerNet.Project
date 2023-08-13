using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //Şirket entity'si
    public class Company : IEntity
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sector { get; set; }
        public DateTime FoundationYear { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Website { get; set; }
        public string LinkedinUrl { get; set; }
        public int UserId { get; set; }
        public List<User> User { get; set; } 

    }
}