using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class ResetPasswordVM
    {
       

        [Required(ErrorMessage = "Enter Password  ")]
        [MinLength(4, ErrorMessage = "min length is 4 chars ")]
      
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Password   ")]
        [MinLength(4, ErrorMessage = "min length is 4 chars ")]
      
        [Compare("Password", ErrorMessage = "password is not    the same ")]
   
        public string ConfirmPassword { get; set; }

        public string Email { get; set; }

        public string Token { get; set; }
    }
}
