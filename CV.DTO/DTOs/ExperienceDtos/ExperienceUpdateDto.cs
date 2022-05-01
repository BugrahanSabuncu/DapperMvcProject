using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.ExperienceDtos
{
    public class ExperienceUpdateDto : IDTOs
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
