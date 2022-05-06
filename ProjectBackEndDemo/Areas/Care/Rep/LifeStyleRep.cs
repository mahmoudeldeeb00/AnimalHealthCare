using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Care.Models;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Care.Rep
{
    public class LifeStyleRep : ILifeStyleRep
    {
        private readonly DbContainer db;
        private readonly IMapper mapper;

        public LifeStyleRep( DbContainer db , IMapper mapper )
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddFood(FoodVM model)
        {
            Food f = mapper.Map<Food>(model);
            db.Foods.Add(f);
            db.SaveChanges();


            foreach (var item in model.AnimalIds)
            {
                AnimalFood af = new AnimalFood();
                af.AnimalId = item;
                af.FoodId = f.Id;
                db.AnimalFoods.Add(af);
                db.SaveChanges();
            }
         
        }

        public void AddLifeStyle(LifeStyleVM model)
        {
            db.LifeStyles.Add(mapper.Map<LifeStyle>(model));
            db.SaveChanges();

        }

        public void EditLifeStyle(LifeStyleVM model )
        {
            var OldLifeStyle = db.LifeStyles.FirstOrDefault(a => a.Id == model.Id);

            //  OldLifeStyle = mapper.Map<LifeStyle>(model);
            OldLifeStyle.AnimalId = model.AnimalId;
            OldLifeStyle.Cleanliness = model.Cleanliness;
            OldLifeStyle.Care = model.Care;
            OldLifeStyle.Mating = model.Mating;


            db.LifeStyles.Update(OldLifeStyle);
            db.SaveChanges();


        }

        public LifeStyleVM GetLifeStyle(int animal)
        {
            var lifestyle = mapper.Map<LifeStyleVM>(db.LifeStyles.FirstOrDefault(f => f.AnimalId == animal));
            lifestyle.Foods = new List<Food>();
            foreach(var item in db.AnimalFoods.Where(w => w.AnimalId == animal).Include(i => i.Food).ToList())
            {
                lifestyle.Foods.Add(item.Food);
            }
            return lifestyle;

        }

        public LifeStyleVM GetLifeStyleById(int id)
        {
            var lifestyle = mapper.Map<LifeStyleVM>(db.LifeStyles.FirstOrDefault(f => f.Id == id));
            
            return lifestyle;
        }
    }
}
