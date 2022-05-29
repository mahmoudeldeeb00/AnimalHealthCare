using ProjectBackEndDemo.Areas.Vets.Models;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Vets.Rep
{
    public interface IVetRep
    {
        public List<VetVM> GetAllVets();
        public VetVM  GetVetById( int Id );
        
        public void CreateVet(VetVM model);

        public void EditVet(VetVM model);
        public Animal GetAnimalById(int id);
        public void UpdatePetData(Animal model);
        public void CreatePet(Animal model);

        


    }
}
