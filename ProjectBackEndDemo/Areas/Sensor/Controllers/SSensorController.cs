using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.Areas.Sensor.Models;
using ProjectBackEndDemo.Areas.Sensor.SensorRep;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Controllers
{
    [Area("Sensor")]
    [Authorize]
    public class SSensorController : Controller
    {
        private readonly DbContainer db;
        private readonly ISensorRep srep;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IHubContext<SignalServer> signalHub;

        public SSensorController(DbContainer db, ISensorRep Srep, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IHubContext<SignalServer> SignalHub)
        {
            this.db = db;
            srep = Srep;
            this.userManager = userManager;
            this.signInManager = signInManager;
            signalHub = SignalHub;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EditPetProfile()
        {
            return View(srep.GetUserAnimalByUserId(userManager.GetUserId(HttpContext.User)));
        }
        [HttpPost]
        public IActionResult EditPetProfile(UserAnimalVM model)
        {
            if (ModelState.IsValid)
            {
                srep.EditPetProfile(model);
                return RedirectToAction("Index", "Home", new { area = "" });
            }
            return View(model);
        }
        public IActionResult EditPetProfilePicture()
        {
            return View(srep.GetUserAnimalPictureToEdit(userManager.GetUserId(HttpContext.User)));
        }
        [HttpPost]
        public IActionResult EditPetProfilePicture(EditAnimalPictureVM model)
        {
            if (ModelState.IsValid)
            {
                srep.EditPetProfilePicture(model);
                return RedirectToAction("EditPetProfile");
            }
            return View(model);
        }

        public IActionResult ViewPet() => View(srep.GetUserAnimalByUserId(userManager.GetUserId(HttpContext.User)));


        [Authorize(Roles = "Admin , Vet")]
        public IActionResult CreateSensorData()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateSensorData(SensorDataVM model)
        {
            if (ModelState.IsValid)
            {
                srep.AddSensorData(model);

                return View();
            }
            else
            {
                return View(model);

            }


        }

        public IActionResult GetSensorData(int Id) => View(srep.GetSensorData(Id));



        public IActionResult Monitoring() {

         
                return View(srep.ViewMonitoring(userManager.GetUserId(HttpContext.User)));
        }


        [Authorize(Roles ="Admin,Vet")]
        public IActionResult AddSensorMeter() => View();
        [HttpPost]
        public IActionResult AddSensorMeter(string Name)
        {
            srep.AddSensorMeter(Name);
            return RedirectToAction("Index","Home",new { area=""});


        }

        //jsons for auto send notification ----------------

        [HttpPost]
        public  JsonResult  GetRandomSensorId()
        {
            if (signInManager.IsSignedIn(User))
            {
                var currentuser =  userManager.FindByNameAsync(User.Identity.Name).Result;
                var random = new Random();
                var list = db.SensorDatas.Where(a => a.AnimalId == currentuser.AnimalId).Select(i => i.Id).ToList();
                var randomId = list[random.Next(list.Count)];
                     return Json(randomId);

            }

            return Json("");
        }

        [HttpPost]
        public  void ChangeLastMonitoring(int ID)
        {
           
                var UserId = userManager.GetUserId(HttpContext.User);
       

            var sensordata = db.SensorDatas.Where(w => w.Id == ID).Include(i => i.SensorMeter).FirstOrDefault();
                var userAnimal = db.UserAnimals.FirstOrDefault(f => f.ApplicationUserId == UserId);
                string TypeName = sensordata.SensorMeter.Name;
                if (TypeName == "Temperature")
                {
                    userAnimal.CurrentTempreture = sensordata.Value;
                    userAnimal.LastSensorTempretureSend = ID;
                    db.SaveChanges();
                }
                else if (TypeName == "Glucose")
                {
                    userAnimal.Currentlucose = sensordata.Value;
                    userAnimal.LastSensorGlucoseSend = ID;
                    db.SaveChanges();

                }
                else if(TypeName == "Pulse")
                {
                    userAnimal.CurrentPulse = sensordata.Value;
                    userAnimal.LastSensorPulseSend = ID;

                    db.SaveChanges();

                }
                  var currentUser = userManager.FindByIdAsync(UserId).Result;
                currentUser.LastSensorSend = ID;
                var result = userManager.UpdateAsync(currentUser).Result;



                _ = signalHub.Clients.All.SendAsync("makeapprealTimeMonitoring", "");


            

        }

        //jsons for make real timt to monitoring page send notification ----------------

        [HttpPost]
        public JsonResult GetCurrentAnimalValues()
        {

            var UserId = userManager.GetUserId(HttpContext.User);
                return Json(srep.ChangeScaleValues(UserId));

            

            
        }


    }
}
