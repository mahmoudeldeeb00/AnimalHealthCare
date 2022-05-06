using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Models
{
    public class SensorDataVM
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Required ")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string HowToDeal { get; set; }
        public bool IsEmergency { get; set; }
        public int AnimalId { get; set; }
        public string AnimalName { get; set; }

        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }


    }
}
