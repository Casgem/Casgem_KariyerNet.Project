﻿using Casgem_DTOLayer.DTOs.Abstract;
using Casgem_EntityLayer.Entities.Concrete;

namespace Casgem_DTOLayer.DTOs.Concrete.EducationInformationDTOs
{
    public class UpdateEducationInformationDTO : IDTO
    {
        public int EducationInformationId { get; set; }
        public string Universite { get; set; }
        public string Faculty { get; set; }
        public string Section { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}