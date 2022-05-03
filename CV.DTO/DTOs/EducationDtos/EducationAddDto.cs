using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.EducationDtos
{
    public class EducationAddDto : IDTOs
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime? EndDate { get; set; }
    }
}
