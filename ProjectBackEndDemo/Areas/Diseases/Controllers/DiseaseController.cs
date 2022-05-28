using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectBackEndDemo.Areas.Diseases.Models;
using ProjectBackEndDemo.Areas.Diseases.Rep;
using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ProjectBackEndDemo.Areas.Diseases.Controllers
{
    [Area("Diseases")]
    [Authorize]
    public class DiseaseController : Controller
    {
        private readonly IDiseaseRep dRep;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public DiseaseController( IDiseaseRep dRep ,UserManager<AppUser> userManager,SignInManager<AppUser>signInManager )
        {
            this.dRep = dRep;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        #region  Dieases 

        public async Task<IActionResult> Index()
        {
            if (signInManager.IsSignedIn(User))
            {
                var currentuser = await userManager.FindByNameAsync(User.Identity.Name);

                    var myList = dRep.GetAllDiseases((int)currentuser.AnimalId);
                     return View(myList);

            }

            return View();

        }

        public async Task<IActionResult> Search(string search)
        {
            if (signInManager.IsSignedIn(User))
            {
                var currentuser = await userManager.FindByNameAsync(User.Identity.Name);

                var myList = dRep.GetAllDiseases((int)currentuser.AnimalId , search );
                    return View(myList);

               
            }

            return View();

        }
       
        [Authorize(Roles = "Admin,Vet")]
        public IActionResult CreateDisease() => View();
        [HttpPost]
        public IActionResult CreateDisease(DieseaseVM model)
        {
            if (ModelState.IsValid)
            {
                dRep.CreateDisease(model);
                return RedirectToAction("Index");

            }

            return View();
        }

        public IActionResult ViewDisease(int id) => View(dRep.GetDieaseById(id));

       [HttpPost]
        public JsonResult DiseaseAutoComplete(string prefix)
        {

            return Json(dRep.DiseaseAutoCmplt(prefix));
        }
        
        #endregion

        #region Medicines 

        public IActionResult ViewMedicines() => View(dRep.GetAllMedicines());
        public IActionResult SearchMedicines(string search) => View(dRep.GetAllMedicines(search));


        [Authorize(Roles = "Admin,Vet")]
        public IActionResult CreateMedicine() => View();
        [HttpPost]
        public IActionResult CreateMedicine(MedicineVM model)
        {
            if (ModelState.IsValid)
            {
                dRep.CreateMedicine(model);


                return RedirectToAction("Index");

            }

            return View();
        }

        public IActionResult ViewMedicine(int id) => View(dRep.GetMedicineById(id));

        #endregion

        #region Symptoms 

        public IActionResult ViewSymptoms() => View(dRep.GetAllSymptoms());

        public IActionResult SearchSymptoms(string search) => View(dRep.GetAllSymptoms(search));

        [Authorize(Roles = "Admin,Vet")]
        public IActionResult CreateSymptom() => View();
        [HttpPost]
        public IActionResult CreateSymptom(SymptomVM model)
        {
            if (ModelState.IsValid)
            {
                dRep.CreateSymptom(model);
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult ViewSymptom(int id) => View(dRep.GetSymptomById(id));

        #endregion


        #region FAQ
        [Authorize(Roles ="Admin,Vet")]
        public IActionResult AddFAQ() => View();

        [HttpPost]
        public IActionResult AddFAQ( FAQVM Faq) {

            if (ModelState.IsValid)
            {
                dRep.CreateFAQ(Faq);
                return RedirectToAction("ViewFAQs");

            }

            return View(Faq);
        }
        public IActionResult ViewFAQs() => View(dRep.GetFAQS());

        public IActionResult SearchFAQs(string search) => View(dRep.GetSearchedFAQS(search));

        #endregion
    }
}
