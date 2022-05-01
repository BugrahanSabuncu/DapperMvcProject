using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.SkillDtos
{
    public class SkillAddDto : IDTOs
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
