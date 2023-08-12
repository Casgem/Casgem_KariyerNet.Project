using Casgem_EntityLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    //İş ilanı Entity'si.
    public class JobAdvertisement : IEntity
    {
        public int JobAdvertisementId { get; set; } //İş ilanı Id
        public string JobDescription { get; set; }//İş tanımı
        public string GeneralQualifications { get; set; } //Genel nitelikler.
        public string Responsibilities { get; set; }
        public string QualificationsAndExperience { get; set; }
        public string Experience { get; set; }
        public string EducationLevel { get; set; }
        public string ForeignLanguage { get; set; }
        public byte ForeignLanguageLevel { get; set; }
        public int WorkExperienceId { get; set; }
        public WorkExperience WorkExperience { get; set; }
        public int JobApplicationId { get; set; }
        public List<JobApplication> JobApplication { get; set; }
    }
}