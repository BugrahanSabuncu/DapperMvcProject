using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.InterestDtos
{
    public class InterestUpdateDto : IDTOs
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
