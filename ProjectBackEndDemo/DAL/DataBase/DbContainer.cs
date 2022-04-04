﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Emergency.Data;
using ProjectBackEndDemo.Areas.Identity.Models;
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
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Vet> Vets { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Emergencyy> Emergencies { get; set; }
    







    }
}
