using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Emergency.Models
{
    public class EmergencyVM
    {
        public int id { get; set; }

        [Required(ErrorMessage = "enter name of emergency ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Select an animal PLZ ")]

        public string Animal { get; set; }

        [MinLength(10, ErrorMessage = "10 character is the minimum ")]
        public string Description { get; set; }
        [MinLength(10, ErrorMessage = "10 character is the minimum ")]

        public string HowToDeal { get; set; }

    }
}
