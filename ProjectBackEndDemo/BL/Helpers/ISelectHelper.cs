using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.Helpers
{
    public interface ISelectHelper
    {

        public List<Animal> GetAnimals();
        public List<Disease> GetDiseases();
        public List<Symptom> GetSymptoms();
        public List<Medicine> GetMedicines();
        public List<City> GetCities();



    }
}
