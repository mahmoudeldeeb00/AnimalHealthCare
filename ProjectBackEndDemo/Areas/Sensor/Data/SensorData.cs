using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Data
{
    public class SensorData
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int Value { get; set; }
        public string Description { get; set; }
        public string HowToDeal { get; set; }
        public bool IsEmergency { get; set; }

        public int AnimalId { get; set; }
        [ForeignKey("AnimalId")]
        public Animal Animal { get; set; }
        public int DiseaseId { get; set; }
        [ForeignKey("DiseaseId")]
        public Disease Disease { get; set; }


        public int? Type { get; set; }
        [ForeignKey("Type")]
        public SensorMeter SensorMeter { get; set; }

    }
}
