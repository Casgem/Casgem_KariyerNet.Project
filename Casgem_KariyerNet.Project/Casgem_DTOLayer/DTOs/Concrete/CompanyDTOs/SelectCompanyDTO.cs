﻿using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.CompanyDTOs
{
    public class SelectCompanyDTO : ISelectDTO
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sector { get; set; }
        public DateTime FoundationYear { get; set; }
        public int NumberOfEmployees { get; set; }
        public string Website { get; set; }
        public string LinkedinUrl { get; set; }
        public int DegreeId { get; set; }
       
    }
}
