using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NToastNotify;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.BL.Helpers;
using ProjectBackEndDemo.BL.IRepository;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using ProjectBackEndDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectBackEndDemo.Contrrollers
{
    [Authorize]
    public class NotificationController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly INotificationRep notify;
        private readonly DbContainer db;
        private readonly IToastNotification not;

        public NotificationController( UserManager<AppUser> userManager,SignInManager<AppUser> signInManager , INotificationRep notify ,DbContainer db,IToastNotification not)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.notify = notify;
            this.db = db;
            this.not = not;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateNotification()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNotification(Notification noty )
        {
            var userId = userManager.GetUserId(HttpContext.User);

            if (ModelState.IsValid)
            {
                var notification = new Notification()
                {
                    Text = noty.Text                  
                };
                notify.CreateNotification(notification, userId);
                return RedirectToAction("Index", "Home", new { area = "" });

            }
            return View();
        }
       
        public IActionResult GetNotification()
        {
            var userId = userManager.GetUserId(HttpContext.User);
            var notifications = notify.GetUserNotifications(userId);
            return Ok(notifications);
        }
     
        public IActionResult GetAllNotification()
        {

            var userId = userManager.GetUserId(HttpContext.User);
            var notifications = notify.GetAllUserNotifications(userId);

            return View (notifications);
        }


        public IActionResult ReadNotification(int notificationId)
        {
            notify.ReadNotification(notificationId, userManager.GetUserId(HttpContext.User));
            return Ok();
        }
        [HttpPost]
        public IActionResult ReadAllNotification()
        {
            notify.ReadAll( userManager.GetUserId(HttpContext.User));
            return Ok();
        }

        public  void CreateAutoNotification(int id)
        {          
            var userId = userManager.GetUserId(HttpContext.User);
            var model = db.SensorDatas.Where(a => a.Id == id).FirstOrDefault();            
            var ani = db.Animals.FirstOrDefault(a => a.Id == model.AnimalId).Name;
            var muUrl = Url.Action("GetSensorData", "SSensor", new { area = "Sensor", Id = id }, Request.Scheme);    
            var notification = new Notification()
            {
                Text = "Your "+ ani +" "+ model.Name  ,
                UrlReference = muUrl
            };
            notify.CreateNotification(notification, userId);


            if(model.IsEmergency == false)
            {
                not.AddInfoToastMessage(notification.Text);
            }
            else
            {
                if (signInManager.IsSignedIn(User))
                {
                    not.AddWarningToastMessage(notification.Text);

                    var currentUser = userManager.FindByNameAsync(User.Identity.Name).Result;
                    if (currentUser.Gmail != null)
                    {
                        MailHelper.SendMail(currentUser.Gmail, notification.Text, notification.UrlReference);

                    }



                }
            }
         



        }
    }
    }
