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
    public class EfCurriculumVitaeDal : GenericRepository<CurriculumVitae>, ICurriculumVitaeDal
    {
        private readonly KariyerNetDbContext _context;

        public EfCurriculumVitaeDal(KariyerNetDbContext context)
        {
            _context = context;
        }

        public void AddCurriculumVitaeForEducationInformation(int curriculumVitaeId, EducationInformation educationInformation)
        {
            var value = _context.CurriculumVitaes.Include(curriculumVitae => curriculumVitae.EducationInformation).Where(curriculumVitae => curriculumVitae.CurriculumVitaeId == curriculumVitaeId).FirstOrDefault();
            value.EducationInformation = educationInformation;
            _context.SaveChanges();
        }

        public void AddCurriculumVitaeForWorkExperience(int curriculumVitaeId, WorkExperience workExperience)
        {
            var value = _context.CurriculumVitaes.Include(curriculumVitae => curriculumVitae.EducationInformation).Where(curriculumVitae => curriculumVitae.CurriculumVitaeId == curriculumVitaeId).FirstOrDefault();
            value.WorkExperience = workExperience;
            _context.SaveChanges();
        }

        public CurriculumVitae GetCurriculumVitaeWithEducationInformation(int id)
        {
            return _context.CurriculumVitaes.Include(curriculumVitae => curriculumVitae.EducationInformation).Where(curriculumVitae => curriculumVitae.CurriculumVitaeId == id).FirstOrDefault();
        }

        public CurriculumVitae GetCurriculumVitaeWithWorkExperience(int id)
        {
            return _context.CurriculumVitaes.Include(curriculumVitae => curriculumVitae.WorkExperience).Where(curriculumVitae => curriculumVitae.CurriculumVitaeId == id).FirstOrDefault();
        }
    }
}
