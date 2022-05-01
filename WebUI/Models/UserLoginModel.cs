using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class UserLoginModel
    {
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
