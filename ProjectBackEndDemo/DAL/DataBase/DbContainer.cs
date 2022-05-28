using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Emergency.Data;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.DataBase
{
    public class DbContainer:IdentityDbContext<AppUser>
    {
        public DbContainer(DbContextOptions<DbContainer> opts ) : base(opts) { }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<DiseasMedicine> DiseaseMedicines { get; set; }
        public DbSet<DiseaseSymptom> DiseaseSymptoms { get; set; }


        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<FAQ> fAQs { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Emergencyy> Emergencies { get; set; }
        public DbSet<SensorData> SensorDatas { get; set; }

        public DbSet<Food> Foods { get; set; }
        public DbSet<AnimalFood> AnimalFoods { get; set; }
        public DbSet<LifeStyle> LifeStyles { get; set; }


        public DbSet<FeedBack> FeedBacks { get;  set; }

        public DbSet<UserAnimal> UserAnimals { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationApplicationUser> UserNotifications { get; set; }

        public DbSet<SensorMeter> SensorMeters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<AppUser>()
            .HasOne(a => a.UserAnimal)
            .WithOne(a => a.AppUser)
            .HasForeignKey<UserAnimal>(c => c.ApplicationUserId);


            builder.Entity<DiseaseSymptom>()
                .HasKey(k => new { k.symptomId, k.DiseaseId });


            builder.Entity<NotificationApplicationUser>()
                 .HasKey(k => new { k.NotificationId, k.ApplicationUserId });

            builder.Entity<DiseasMedicine>()
                .HasKey(k => new { k.DiseaseId, k.MedicineId });

            builder.Entity<AnimalFood>()
                .HasKey(k => new { k.AnimalId, k.FoodId });

            builder.Entity<UserAnimal>()
                .HasKey(k => new { k.ApplicationUserId, k.AnimalId });


            base.OnModelCreating(builder);
        }




    }
}
