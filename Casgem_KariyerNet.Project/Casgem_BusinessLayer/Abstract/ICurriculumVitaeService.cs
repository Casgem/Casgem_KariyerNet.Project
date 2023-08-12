using Casgem_EntityLayer.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_BusinessLayer.Abstract
{
    public interface ICurriculumVitaeService : IGenericService<CurriculumVitae>
    {
        public CurriculumVitae GetCurriculumVitaeWithWorkExperience(int id);
        public CurriculumVitae GetCurriculumVitaeWithEducationInformation(int id);
    }
}
