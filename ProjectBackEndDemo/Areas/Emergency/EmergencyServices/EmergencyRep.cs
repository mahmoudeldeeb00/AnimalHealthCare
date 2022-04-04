using AutoMapper;
using ProjectBackEndDemo.Areas.Emergency.Data;
using ProjectBackEndDemo.Areas.Emergency.Models;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Emergency.EmergencyServices
{
    public class EmergencyRep : IEmergencyRep
    {
        private readonly DbContainer db;
        private readonly IMapper mapper;

        public EmergencyRep( DbContainer db ,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }

        public void AddEmergency(EmergencyVM model)
        {
            var emergency = mapper.Map<Emergencyy>(model);
           var  result = db.Add(emergency);
            db.SaveChanges();
           



        }

        public IEnumerable<EmergencyVM> GetAllEmergences()
        {
            var data = db.Emergencies.Select(a => new EmergencyVM
            {
                id = a.id,
                Animal = a.Animal,
                Description = a.Description,
                Name = a.Name,
                HowToDeal = a.HowToDeal
            });
            return (data);

        }

        public IEnumerable<Animal> GetAnimals()
        { 
            return  db.Animals.ToList();
          
        }
    }
}
