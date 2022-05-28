using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectBackEndDemo.Areas.Care.Models;
using ProjectBackEndDemo.Areas.Care.Rep;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Care.Controllers
{
    [Area("Care")]
    [Authorize]
    public class LifeStyleController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly ILifeStyleRep lFRer;

        public LifeStyleController( UserManager<AppUser> userManager , SignInManager<AppUser> signInManager , ILifeStyleRep LFRer)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            lFRer = LFRer;
        }


        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                var currentUser =  await userManager.FindByNameAsync(User.Identity.Name);

                     return View(lFRer.GetLifeStyle((int)currentUser.AnimalId));

               
            }

            return View();
        }
        public IActionResult AjaxGetLifeStyleWithId(int Id)
        {
            var x = lFRer.GetLifeStyle(Id);
            return Ok(x);
        }


        [Authorize(Roles = "Admin , Vet")]
        public IActionResult CreateFood() => View();
     
        [HttpPost]
        public IActionResult CreateFood(FoodVM model)
        {
            if (ModelState.IsValid)
            {
                lFRer.AddFood(model);
                return RedirectToAction("Index");
            }

            return View();
        }
        [Authorize(Roles = "Admin , Vet")]
        public IActionResult CreateLifeStyle() => View();     
        [HttpPost]
        public IActionResult CreateLifeStyle(LifeStyleVM model)
        {
            if (ModelState.IsValid)
            {
                lFRer.AddLifeStyle(model);
                return RedirectToAction("Index");
            }


            return View(model);
        }


        [Authorize(Roles = "Admin , Vet")]
        public IActionResult EditLifeStyle(int id) => View(lFRer.GetLifeStyleById(id));
        
        [HttpPost]
        public IActionResult EditLifeStyle(LifeStyleVM model)
        {
            if (ModelState.IsValid)
            {
                lFRer.EditLifeStyle(model);
                return RedirectToAction("Index");
            }


            return View(model);
        }



    }
}
