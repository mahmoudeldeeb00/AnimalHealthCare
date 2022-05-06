using ProjectBackEndDemo.Areas.Sensor.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class Disease
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public bool IsInfect { get; set; }

        public int? AnimalId { get; set; } 
        [ForeignKey("AnimalId")]
        public Animal Animal  { get; set; }

        public string KeyWords { get; set; }
        public virtual ICollection<SensorData> SensorDatas { get; set; }
       
        public virtual ICollection<DiseasMedicine> DiseasMedicines { get; set; }
        public virtual ICollection<DiseaseSymptom> DiseaseSymptom { get; set; }



    }
}
