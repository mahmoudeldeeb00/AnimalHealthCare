using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Vets.Models;
using ProjectBackEndDemo.BL.Helpers;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Vets.Rep
{
    public class VetRep : IVetRep
    {
        private readonly IMapper mapper;
        private readonly DbContainer db;

        public VetRep(IMapper mapper , DbContainer db)
        {
            this.mapper = mapper;
            this.db = db;
        }
        public void CreateVet(VetVM model)
        {
            var NewVet = mapper.Map<Vet>(model);
            NewVet.PictureUrl = SaveFileHelper.SaveFile("VetPictures", model.Picture);
            db.Vets.Add(NewVet);
            db.SaveChanges();

        }

        public List<VetVM> GetAllVets() 
        {
            var VetList = new List<VetVM>();
           foreach(var item in db.Vets.Include(a=> a.City).ToList())
            {

                VetVM vet = mapper.Map<VetVM>(item);
                vet.CityName = item.City.Name;
                

                VetList.Add(vet);

            }

            return (VetList);
        }

        public VetVM GetVetById(int Id) {
            var item = db.Vets.Include(a => a.City).FirstOrDefault(a => a.Id == Id);
           var vet =  mapper.Map<VetVM>(item);
            vet.CityName = item.City.Name;
            return vet;
        } 
        public void EditVet(VetVM model)
        {
            var oldVet = db.Vets.FirstOrDefault(a => a.Id == model.Id);
            oldVet.Name = model.Name;
            oldVet.Telephone = model.Telephone;
            oldVet.CityId = model.CityId;
            oldVet.age = model.age;
            oldVet.Address = model.Address;
            oldVet.PictureUrl = SaveFileHelper.SaveFile("VetPictures", model.Picture);
            db.Vets.Update(oldVet);
            db.SaveChanges();

        }
    }
}
