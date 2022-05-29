using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBackEndDemo.Areas.Vets.Models;
using ProjectBackEndDemo.Areas.Vets.Rep;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Vets.Controllers
{
    [Authorize]
    [Area("Vets")]
    public class VetController : Controller
    {
        private readonly IVetRep vRep;

        public VetController(IVetRep VRep)
        {
            vRep = VRep;
        }
        public IActionResult Index() => View(vRep.GetAllVets());

        [Authorize(Roles = "Admin,Vet")]

        public IActionResult CreateVet() => View();
        [HttpPost]
        public IActionResult CreateVet(VetVM model) {

            if (ModelState.IsValid)
            {
                vRep.CreateVet(model);

                return RedirectToAction("Index");
            }

            return View(model);
        }
        public IActionResult EditVet(int Id) => View(vRep.GetVetById(Id));
        [HttpPost]
        public IActionResult EditVet(VetVM model)
        {
            if (ModelState.IsValid)
            {
                vRep.EditVet(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public IActionResult ViewVet(int Id)
        {

            return View(vRep.GetVetById(Id));
        }
        [Authorize(Roles = "Admin,Vet")]
        public IActionResult VetAreaToManageData()
        {

            return View();
        }
        [Authorize(Roles = "Admin,Vet")]

        public IActionResult EditPet(int Id) => View(vRep.GetAnimalById(Id));
       [HttpPost]
        public IActionResult EditPet(Animal AnimalModel)
        {
            vRep.UpdatePetData(AnimalModel);
            return RedirectToAction("VetAreaToManageData");

        }
        [Authorize(Roles = "Admin,Vet")]

        public IActionResult AddAnimal() => View();
        [HttpPost]
        public IActionResult AddAnimal(Animal model) {

            vRep.CreatePet(model);

            return RedirectToAction("VetAreaToManageData");

        }




    }
}
