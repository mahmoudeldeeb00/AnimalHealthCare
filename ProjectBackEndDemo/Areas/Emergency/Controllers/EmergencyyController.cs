using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBackEndDemo.Areas.Emergency.EmergencyServices;
using ProjectBackEndDemo.Areas.Emergency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Emergency.Controllers
{
    [Authorize]
    [Area("Emergency")]
    public class EmergencyyController : Controller
    {
        private readonly IEmergencyRep erep;

        public EmergencyyController(IEmergencyRep Erep )
        {
            erep = Erep;
        }
        public IActionResult Index() => View();

        [Authorize(Roles = "Vet,Admin")]

        public IActionResult CreateEmergency() => View();
       
        [HttpPost]
        public IActionResult CreateEmergency(EmergencyVM model)
        {
            if (ModelState.IsValid)
            {
                erep.AddEmergency(model);
                    return RedirectToAction("Index");

            }
           
            return View(model);

        }



        /// ajax call ---------------- ////
        ///
        [HttpPost]

        public JsonResult FilterData(string name)
        {
            var list = erep.GetAllEmergences().Where(a => a.Animal == name );


            return Json(list);
        }





    }
}
