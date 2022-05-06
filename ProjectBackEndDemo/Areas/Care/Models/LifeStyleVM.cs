using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Care.Models
{
    public class LifeStyleVM
    {

        public int Id { get; set; }
        [Required(ErrorMessage ="Required")]
        public int AnimalId { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Cleanliness { get; set; }
        [Required(ErrorMessage ="Required")]
        public string Mating { get; set; }
        [Required(ErrorMessage = "Required")]
        public string Care { get; set; }
        public List<Food> Foods { get; set; }
    }
}
