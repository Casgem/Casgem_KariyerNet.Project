using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ünvan!!!!
namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş verenlerin ve iş arayanların ünvan Entity'si.
    public class Degree : IEntity
    {
        public int DegreeId { get; set; } //ünvan id
        //public int CompanyId { get; set; } //şirket id'si. 1'e çok
        //public Company Company { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
    }
}