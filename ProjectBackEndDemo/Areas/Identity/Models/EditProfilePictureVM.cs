using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class EditProfilePictureVM
    {
        public string Id { get; set; }
        public string ProfilePic { get; set; }
        [Required]
        public IFormFile ProfilePicture { get; set; }
    }
}
