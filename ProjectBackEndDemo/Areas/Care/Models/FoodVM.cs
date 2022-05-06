using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Care.Models
{
    public class FoodVM
    { 
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]

        public List<int> AnimalIds  { get; set; }
        [Required(ErrorMessage = "Required")]

        public string Name { get; set; }
        public string Description { get; set; }

    }
}
