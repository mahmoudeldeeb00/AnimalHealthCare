
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.BL.Helpers;
using ProjectBackEndDemo.BL.IRepository;
using ProjectBackEndDemo.DAL.DataBase;
using ProjectBackEndDemo.DAL.Entities;
using ProjectBackEndDemo.Infrastructure;
using ProjectBackEndDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProjectBackEndDemo.BL.Repository
{
    public class NotificationRep : INotificationRep
    {
        private readonly DbContainer db;
        private readonly IHubContext<SignalServer> SignalHub;
    
        public NotificationRep(DbContainer db,IHubContext<SignalServer> SignalHub)
        {
            this.db = db;
            this.SignalHub = SignalHub;
           
        }


        public  void CreateNotification(Notification notification , string userId)
        {
            db.Notifications.Add(notification);          
            db.SaveChanges();

            var usernotification = new NotificationApplicationUser();
            usernotification.NotificationId = notification.Id;
              usernotification.ApplicationUserId = userId;
            usernotification.Time = DateTime.Now;
            db.UserNotifications.Add(usernotification);
            db.SaveChanges();

            SignalHub.Clients.All.SendAsync("displayNotification", "");


        
        }

        public List<NotificationVM> GetAllUserNotifications(string userId)
        {

            var dbnotiefies = db.UserNotifications.Where(a => a.ApplicationUserId == userId )
               .Include(n => n.Notification)
               .ToList();

            var notifies = new List<NotificationVM>();
            foreach (var item in dbnotiefies.Reverse<NotificationApplicationUser>())
            {
                NotificationVM x = new NotificationVM()
                {
                    id = item.NotificationId,
                    text = item.Notification.Text,
                    time = TimeStringHelper.GetTimeSince(item.Time),
                    UrlReference = item.Notification.UrlReference
                };
                notifies.Add(x);

            }
            return (notifies);
        }

        public List<NotificationVM> GetUserNotifications(string userId)
        {
            var dbnotiefies =  db.UserNotifications.Where(a => a.ApplicationUserId == userId && a.IsRead == false)
                .Include( n => n.Notification)
                .ToList();

            var notifies = new List<NotificationVM>();
            foreach (var item in dbnotiefies.Reverse<NotificationApplicationUser>())
            {
                NotificationVM x = new NotificationVM()
                {
                    id = item.NotificationId,
                    text = item.Notification.Text,
                    time = TimeStringHelper.GetTimeSince(item.Time),
                    UrlReference = item.Notification.UrlReference

                };
                notifies.Add(x);

            }
            return (notifies);


        }

        public void ReadNotification(int notificationid, string userId)
        {
            var notification = db.UserNotifications
                 .FirstOrDefault(n => n.NotificationId.Equals(notificationid) && n.ApplicationUserId == userId);
            notification.IsRead = true;

            db.UserNotifications.Update(notification);
            db.SaveChanges();               
        }
    }
}
