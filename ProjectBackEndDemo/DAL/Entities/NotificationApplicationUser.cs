using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class NotificationApplicationUser
    {
        public int NotificationId { get; set; }
        public Notification Notification { get; set; }
        public string ApplicationUserId { get; set; }
        public AppUser ApplicationUser { get; set; }
        public DateTime Time { get; set; }
     

        public bool IsRead { get; set; } = false;



    }
}
