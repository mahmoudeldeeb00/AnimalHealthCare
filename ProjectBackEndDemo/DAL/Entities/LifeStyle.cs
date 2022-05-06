using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class LifeStyle
    {
        [Key]
        public int Id { get; set; }

        public int AnimalId { get; set; }
        [ForeignKey("AnimalId")]
        public Animal Animal { get; set; }

        public string Cleanliness { get; set; }
        public string Mating { get; set; }
        public string Care { get; set; }




    }
}
