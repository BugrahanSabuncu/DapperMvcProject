using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class UserUpdateModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim Gereklidir.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Soyisim Gereklidir.")]
        public string LastName { get; set; }
        public string Address { get; set; }
        [Required(ErrorMessage = "Email Gereklidir.")]
        public string Email { get; set; }
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Telefon Numarası Gereklidir.")]
        public string PhoneNumber { get; set; }
        public string ShortDescription { get; set; }
        public IFormFile Picture { get; set; }
    }
}
