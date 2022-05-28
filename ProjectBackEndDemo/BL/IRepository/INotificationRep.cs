using ProjectBackEndDemo.DAL.Entities;
using ProjectBackEndDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.IRepository
{
    public interface INotificationRep
    {
        public List<NotificationVM> GetUserNotifications(string userId);
        public List<NotificationVM> GetAllUserNotifications(string userId);

        public void CreateNotification(Notification notification , string userId);
        public void ReadNotification(int notificationid, string userId);
        public void ReadAll(string userId);


        
    }
}
