using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Diseases.Models;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.Areas.Sensor.Models;
using ProjectBackEndDemo.BL.Helpers;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.SensorRep
{
    public class SensorRep : ISensorRep
    {
        private readonly DbContainer db;
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;

        public SensorRep( DbContainer db , IMapper mapper, UserManager<AppUser>userManager )
        {
            this.db = db;
            this.mapper = mapper;
            this.userManager = userManager;
        }
        public void AddSensorData(SensorDataVM model)
        {
            SensorData newone = mapper.Map<SensorData>(model);
            db.SensorDatas.Add(newone);
            db.SaveChanges();
        }

        public SensorDataVM GetSensorData(int Id)
        {
            SensorData mysesordata = db.SensorDatas.Where(a => a.Id == Id)
                .Include(a=> a.Animal )
                .Include(d=> d.Disease)
                .FirstOrDefault();
          SensorDataVM  mysesordataVM = mapper.Map<SensorDataVM>(mysesordata);
            mysesordataVM.AnimalName = mysesordata.Animal.Name;
            mysesordataVM.DiseaseName = mysesordata.Disease.Name;
            mysesordataVM.TypeName = db.SensorMeters.Where(w => w.Id == mysesordata.Type).Select(s => s.Name).FirstOrDefault();
            var MedicineList = new List<MedicineVM>();
            foreach(var item in db.DiseaseMedicines.Where(w=>w.DiseaseId== mysesordata.DiseaseId).Include(i=>i.Medicine).ToList())
            {
                MedicineList.Add(mapper.Map<MedicineVM>(item.Medicine));
            }
            mysesordataVM.RecommendedMedicines = MedicineList;
            return mysesordataVM;

        }

        public void AddSensorMeter(string Name)
        {
            SensorMeter newOne = new SensorMeter()
            {
                Name = Name
            };

            db.SensorMeters.Add(newOne);
            db.SaveChanges();
        }
        public MonitoringVM ViewMonitoring(string UserId)
        {
            MonitoringVM model = new MonitoringVM();
            var UserAni = db.UserAnimals
                .Include(i => i.Animal)
                .Include(ii => ii.Gender)
                .FirstOrDefault(f => f.ApplicationUserId == UserId);


            model.AnimalType = UserAni.Animal.Name;
            model.AnimalNickName = UserAni.Name;
            model.AnimalGenderType = UserAni.Gender.Name;
            model.AnimalId = UserAni.AnimalId;
            model.AnimalAge = TimeStringHelper.GetAgeFromDate(UserAni.BirthDay);
            model.CurrentTempreture = UserAni.CurrentTempreture;
            model.StartTempreture = UserAni.Animal.StartTempreture;
            model.EndTempreture = UserAni.Animal.EndTempreture;
            model.CurrentClucose = UserAni.Currentlucose;
            model.EndClucose = UserAni.Animal.EndGlucose;
            model.StartClucose = UserAni.Animal.StartGlucose;

            model.CurrentPulse = UserAni.CurrentPulse;
            model.StartPulse = UserAni.Animal.StartPulse;
            model.EndPulse = UserAni.Animal.EndPulse;
            model.AnimalPicSource = UserAni.pictureSrc;

            model.LastGlucoseSend = GetSensorData(UserAni.LastSensorGlucoseSend);
            model.LastPulseSend = GetSensorData(UserAni.LastSensorPulseSend);
            model.LastTempretureSend = GetSensorData(UserAni.LastSensorTempretureSend);
          
            return model;

        }
        public UserAnimalVM GetUserAnimalByUserId(string UserId)
        {
            var useranimal = db.UserAnimals
                .Include(i=>i.Animal)
                .Include(f=> f.Gender)
                .FirstOrDefault(f => f.ApplicationUserId == UserId);
            if(useranimal != null)
            {
                var model = mapper.Map<UserAnimalVM>(useranimal);
                model.BirthDay = useranimal.BirthDay;
                model.AnimalType = useranimal.Animal.Name;
                model.AnimalGenderType = useranimal.Gender.Name;
                model.AnimalStringAge = TimeStringHelper.GetAgeFromDate(useranimal.BirthDay);
                return model;
            }
            else
            {
                UserAnimalVM x = new UserAnimalVM() { 
                ApplicationUserId = UserId

                };
                return x;
            }



        }
        public  void  EditPetProfile(UserAnimalVM model)
        {
            var CurrentUser =  userManager.FindByIdAsync(model.ApplicationUserId).Result;

            CurrentUser.AnimalId = model.AnimalId;
           var result =  userManager.UpdateAsync(CurrentUser).Result;

            var useranimalentity = db.UserAnimals.Where(f => f.ApplicationUserId == model.ApplicationUserId).FirstOrDefault();
           
            
            if (useranimalentity != null)
            {
                db.UserAnimals.Remove(useranimalentity);
                db.SaveChanges();

                model.pictureSrc = useranimalentity.pictureSrc;
                db.UserAnimals.Add(mapper.Map<UserAnimal>(model));
                db.SaveChanges();
            }
            else
            {
               db.UserAnimals.Add( mapper.Map<UserAnimal>(model));
                db.SaveChanges();
            }
        }
        public EditAnimalPictureVM GetUserAnimalPictureToEdit(string UserId)
        {
            var useranimal = db.UserAnimals.FirstOrDefault(f => f.ApplicationUserId == UserId);
            if (useranimal != null)
            {
                EditAnimalPictureVM model = new EditAnimalPictureVM()
                {
                    ApplicationUserId = UserId,
                    pictureSrc = useranimal.pictureSrc
                };

                return model;
            }
            else
            {
                EditAnimalPictureVM model = new EditAnimalPictureVM()
                {
                    ApplicationUserId = UserId
                };
                return model;
            }


        }

        public void EditPetProfilePicture(EditAnimalPictureVM model)
        {
            var useranimalentity = db.UserAnimals.FirstOrDefault(f => f.ApplicationUserId == model.ApplicationUserId);
            if (useranimalentity != null)
            {
                useranimalentity.pictureSrc = SaveFileHelper.SaveFile("UserAnimalPictures", model.AnimalPicture) ;
                db.UserAnimals.Update(useranimalentity);
                db.SaveChanges();
            }
         
        }


    }
}
