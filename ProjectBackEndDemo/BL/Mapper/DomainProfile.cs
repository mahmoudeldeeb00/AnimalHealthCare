using AutoMapper;
using ProjectBackEndDemo.Areas.Care.Models;
using ProjectBackEndDemo.Areas.Diseases.Models;
using ProjectBackEndDemo.Areas.Emergency.Data;
using ProjectBackEndDemo.Areas.Emergency.Models;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.Areas.Sensor.Models;
using ProjectBackEndDemo.Areas.Vets.Models;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.Mapper
{
    public class DomainProfile:Profile
    {
        public DomainProfile()
        {
            CreateMap<Emergencyy, EmergencyVM>();
            CreateMap<EmergencyVM, Emergencyy>();

            CreateMap<SensorData, SensorDataVM>();
            CreateMap<SensorDataVM, SensorData>();


            CreateMap<Disease, DieseaseVM>();
            CreateMap<DieseaseVM, Disease>();

            CreateMap<Medicine, MedicineVM>();
            CreateMap<MedicineVM, Medicine>();

            CreateMap<Symptom, SymptomVM>();
            CreateMap<SymptomVM, Symptom>();

            CreateMap<Vet, VetVM>();
            CreateMap<VetVM, Vet>();

            CreateMap<Food, FoodVM>();
            CreateMap<FoodVM, Food>();

            CreateMap<LifeStyle, LifeStyleVM>();
            CreateMap<LifeStyleVM, LifeStyle>();

            CreateMap<FAQ, FAQVM>();
            CreateMap<FAQVM, FAQ>();

            CreateMap<UserAnimal, UserAnimalVM>();
            CreateMap<UserAnimalVM, UserAnimal>();
        }

    }
}
