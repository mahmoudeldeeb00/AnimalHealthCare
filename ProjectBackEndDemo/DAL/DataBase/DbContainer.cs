using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.DataBase
{
    public class DbContainer:DbContext
    {
        public DbContainer(DbContextOptions<DbContainer> opts ) : base(opts) { }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }





    }
}
