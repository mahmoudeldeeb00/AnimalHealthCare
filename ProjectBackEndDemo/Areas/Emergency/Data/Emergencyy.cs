using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Emergency.Data
{
    public class Emergencyy
    {
        [Key]
        public int id { get; set; }

        public string Name { get; set; }


        public string Animal { get; set; }

        public string Description { get; set; }

        public string HowToDeal { get; set; }

    }
}
