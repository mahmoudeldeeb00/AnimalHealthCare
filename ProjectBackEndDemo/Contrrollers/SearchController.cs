using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectBackEndDemo.Areas.Diseases.Rep;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.BL.IRepository;
using ProjectBackEndDemo.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Contrrollers
{
    [Authorize]
    public class SearchController : Controller
    {
        private readonly IDiseaseRep dRep;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public SearchController(IDiseaseRep DRep,UserManager<AppUser> userManager , SignInManager<AppUser>signInManager)
        {
            dRep = DRep;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
      
        
        public IActionResult AllSearch(string search)
        {
            if (signInManager.IsSignedIn(User))
            {
                var currentUser =  userManager.FindByNameAsync(User.Identity.Name).Result;
                var DList = dRep.GetAllDiseases(currentUser.AnimalId , search);
                ViewBag.search = search; 
                return View(DList);
            }
          
            return View();
        }
     

    }
}
