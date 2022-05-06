using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class AnimalFood
    {
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
        public int FoodId { get; set; }
        public Food Food  { get; set; }


    }
}
