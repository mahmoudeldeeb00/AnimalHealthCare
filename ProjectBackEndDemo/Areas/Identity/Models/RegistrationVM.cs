using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class RegistrationVM
    {

        [Required(ErrorMessage = "Enter User Name ")]
        [MinLength(5,ErrorMessage = "min length to user name is 5  ")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Enter Email ")]
        [EmailAddress(ErrorMessage = " enter a valid email adress")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password between 4 , 14 chars  ")]
        [MinLength(4, ErrorMessage = "min length is 4 chars ")]
        [MaxLength(14, ErrorMessage = "max length is 14 chars ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Password between 4 , 14 chars  ")]
        [MinLength(4, ErrorMessage = "min length is 4 chars ")]
        [MaxLength(14, ErrorMessage = "max length is 14 chars ")]
        [Compare("Password", ErrorMessage = "password is not    the same ")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

    }
}
