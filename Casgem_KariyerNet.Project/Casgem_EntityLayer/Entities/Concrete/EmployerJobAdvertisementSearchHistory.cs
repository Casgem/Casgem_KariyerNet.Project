using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş ilanı arama kısmı geçmişi Entity'si.
    public class EmployerJobAdvertisementSearchHistory : IEntity
    {
        public int EmployerJobAdvertisementSearchHistoryId { get; set; }
        public string Word { get; set; }
        public int EmployerId { get; set; }
        public Employer Employer { get; set; }
    }
}