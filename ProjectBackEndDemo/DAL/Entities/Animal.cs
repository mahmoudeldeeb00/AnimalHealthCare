using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.Areas.Sensor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int StartTempreture { get; set; }
        public int EndTempreture { get; set; }
     


        public int StartGlucose{ get; set; }
        public int EndGlucose { get; set; }
      


        public int StartPulse { get; set; }
        public int EndPulse { get; set; }




        public int StartTempretureEmergency { get; set; }
        public int EndTempretureEmergency { get; set; }
        public int StartGlucozEmergency { get; set; }
        public int EndGlucozEmergency { get; set; }
        public int StartPulseEmergency { get; set; }
        public int EndPulseEmergency { get; set; }

        public UserAnimal UserAnimal { get; set; }

        public List<Disease> Disease { get; set; }
       public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual ICollection<SensorData> SensorDatas { get; set; }
        public virtual ICollection<AnimalFood> AnimalFood { get; set; }


    }
}
