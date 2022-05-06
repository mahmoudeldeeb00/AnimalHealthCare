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
       
       
        public List<Disease> Disease { get; set; }
       public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual ICollection<SensorData> SensorDatas { get; set; }
        public virtual ICollection<AnimalFood> AnimalFood { get; set; }


    }
}
