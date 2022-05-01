using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.CertificationDtos
{
    public class CertificationUpdateDto : IDTOs
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
