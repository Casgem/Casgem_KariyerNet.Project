﻿using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EmployerDTOs
{
    public class UpdateEmployerDTO : IDTO
    {
        public int EmployerId { get; set; }
        public int CompanyId { get; set; }
        public List<Company> Companies { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string LinkedinUrl { get; set; }
        public string ProfilePhoto { get; set; }
        public string About { get; set; }
        public int AppUserId { get; set; } //bir iş veren üye olan kullanıcı ile 1'e 1 ilişkili.
        public AppUser AppUser { get; set; } //bir iş veren üye olan kullanıcı ile 1'e 1 ilişkili.
        //public int EmployerJobAdvertisementSearchHistoryId { get; set; }//iş veren geçmişi 1'e çok ilişkili.       
        //public int JobAdvertisementId { get; set; } //iş veren iş ilanlarına 1'e çok ilişkili.
        public List<JobAdvertisement> JobAdvertisements { get; set; } //iş verenin yayınladığı birden fazla iş ilanı var.

    }
}