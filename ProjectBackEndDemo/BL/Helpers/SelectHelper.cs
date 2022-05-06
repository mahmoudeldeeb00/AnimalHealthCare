using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.Helpers
{
    public class SelectHelper : ISelectHelper
    {
        private readonly DbContainer db;

        public SelectHelper(DbContainer db)
        {
            this.db = db;
        }

        public List<Animal> GetAnimals() => db.Animals.ToList();
        public List<Disease> GetDiseases() => db.Diseases.ToList();

        public List<Medicine> GetMedicines() => db.Medicines.ToList();

        public List<Symptom> GetSymptoms() => db.Symptoms.ToList();
        public List<City> GetCities() => db.Cities.ToList();


    }
}
