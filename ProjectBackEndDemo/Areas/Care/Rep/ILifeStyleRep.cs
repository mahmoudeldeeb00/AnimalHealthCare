using ProjectBackEndDemo.Areas.Care.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Care.Rep
{
   public  interface ILifeStyleRep
    {
        public void AddFood(FoodVM model);
        public void AddLifeStyle(LifeStyleVM model);

        public LifeStyleVM GetLifeStyle(int animal);
        public void EditLifeStyle(LifeStyleVM model);
        public LifeStyleVM GetLifeStyleById(int id);



    }
}
