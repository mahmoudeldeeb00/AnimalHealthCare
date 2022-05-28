using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Models
{
    public class UserAnimalVM
    {
        public string ApplicationUserId { get; set; }
       
        [Required(ErrorMessage ="Required")]
        public int AnimalId { get; set; }
        [Required(ErrorMessage ="Required")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Required")]

        public int GenderType { get; set; }
        public string AnimalType { get; set; }
        public string AnimalGenderType { get; set; }
        public string AnimalStringAge { get; set; }
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
