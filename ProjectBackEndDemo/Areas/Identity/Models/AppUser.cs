using Microsoft.AspNetCore.Identity;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class AppUser : IdentityUser 
    {
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public string ProfilePic { get; set; }

        public string Gmail { get; set; }
     
        public List<NotificationApplicationUser> NotificationApplicationUsers { get; set; }




        public int? AnimalId { get; set; }
        [ForeignKey("AnimalId")]

        public virtual Animal Animal { get; set; }



        public int? LastSensorSend { get; set; }

      

        public UserAnimal UserAnimal { get; set; }
    }
}
