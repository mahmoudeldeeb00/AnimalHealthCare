using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.Areas.Sensor.Data;
using ProjectBackEndDemo.Areas.Sensor.Models;
using ProjectBackEndDemo.Areas.Sensor.SensorRep;
using ProjectBackEndDemo.DAL.DataBase;
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

        public SSensorController(DbContainer db , ISensorRep Srep,UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            this.db = db;
            srep = Srep;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles ="Admin , Vet")]
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

        public IActionResult GetSensorData (int Id) =>  View(srep.GetSensorData(Id));






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


    }
}
