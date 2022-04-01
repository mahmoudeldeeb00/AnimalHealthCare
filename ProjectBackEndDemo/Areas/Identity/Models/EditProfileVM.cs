using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class EditProfileVM
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Enter UserName")]
        [MinLength(10,ErrorMessage ="min length 10 ")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Enter Email")]
        [EmailAddress(ErrorMessage ="enter Valid Email")]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public string ProfilePic { get; set; }
        public IFormFile ProfilePicture { get; set; }



    }
}
