using System;
using System.Collections.Generic;
using System.Text;
using CV.DTO.Interfaces;

namespace CV.DTO.DTOs.AppUserDtos
{
    public class AppUserPasswordDto : IDTOs
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
