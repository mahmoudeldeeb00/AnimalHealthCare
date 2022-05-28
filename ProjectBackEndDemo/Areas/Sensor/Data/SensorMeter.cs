using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Data
{
    public class SensorMeter
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }


    }
}
