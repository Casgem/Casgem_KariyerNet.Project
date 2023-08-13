﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_EntityLayer.Entities.Concrete
{
    public class User
    {
        public int UserId { get; set; } //İş arayan Id
        public string City { get; set; }
        public string District { get; set; }
        public string LinkedinUrl { get; set; }
        public string ProfilePhoto { get; set; }
        public string About { get; set; }

        //user Cv'si
        public int CurriculumVitaeId { get; set; }
        public CurriculumVitae CurriculumVitae { get; set; } //bir iş arayanın bir tane CV'si var bizim projemizde.

        //gecmis is basvurulari
        public List<JobApplication> JobApplications { get; set; }

        //egitim gecmisi
        public int EducationInformationId { get; set; }
        public EducationInformation EducationInformation { get; set; }

        //calisiyorsa sirket Id
        public int CompanyId { get; set; }
        public Company Companies { get; set; }

        //basvrdugu is ilani Id'si
        public int JobAdvertisementId { get; set; } //iş veren iş ilanlarına 1'e çok ilişkili.
        public List<JobAdvertisement> JobAdvertisements { get; set; } //iş verenin yayınladığı birden fazla iş ilanı var.
    }
}
