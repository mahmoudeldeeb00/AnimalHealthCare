using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class UserAnimal
    {
        public string ApplicationUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public string Name { get; set; }
        public int GenderType { get; set; }
        [ForeignKey("GenderType")]
        public Gender Gender { get; set; }
        public string pictureSrc { get; set; }
        public DateTime BirthDay { get; set; }
        public int LastSensorTempretureSend { get; set; }
        public int LastSensorGlucoseSend { get; set; }
        public int LastSensorPulseSend { get; set; }
        public int CurrentTempreture { get; set; }
        public int Currentlucose { get; set; }
        public int CurrentPulse { get; set; }


    }
}
