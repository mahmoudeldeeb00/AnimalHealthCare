using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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





        public virtual ICollection<Animal> Animal { get; set; }
        public virtual ICollection<Medicine> Medicine { get; set; }
        public virtual ICollection<Symptom> Symptom { get; set; }



    }
}
