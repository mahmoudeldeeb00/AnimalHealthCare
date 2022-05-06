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
        List<NotificationVM> GetUserNotifications(string userId);
        List<NotificationVM> GetAllUserNotifications(string userId);

        void CreateNotification(Notification notification , string userId);
        void ReadNotification(int notificationid, string userId);
    }
}
