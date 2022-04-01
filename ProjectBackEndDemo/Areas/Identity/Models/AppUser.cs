using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class AppUser : IdentityUser 
    {
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string ProfilePic { get; set; }


    }
}
