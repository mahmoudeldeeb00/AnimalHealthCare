using ProjectBackEndDemo.Areas.Emergency.Data;
using ProjectBackEndDemo.Areas.Emergency.Models;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





namespace ProjectBackEndDemo.Areas.Emergency.EmergencyServices
{
 public   interface IEmergencyRep
    {

        public IEnumerable<EmergencyVM> GetAllEmergences();
        public IEnumerable<Animal> GetAnimals();

        public void AddEmergency(EmergencyVM model);

    }
}
