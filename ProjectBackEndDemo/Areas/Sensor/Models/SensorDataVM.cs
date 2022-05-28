using ProjectBackEndDemo.Areas.Diseases.Models;
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
        [Required(ErrorMessage = "Required")]

        public int Value { get; set; }

        public bool IsEmergency { get; set; }
        [Required(ErrorMessage = "Required")]

        public int AnimalId { get; set; }
        public string AnimalName { get; set; }

        public int DiseaseId { get; set; }
        public string DiseaseName { get; set; }
       [Required(ErrorMessage ="Required")]
        public int? Type { get; set; }

        public string TypeName { get; set; }

        public List<MedicineVM> RecommendedMedicines { get; set; }
    }
}
