using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.DAL.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Rep
{
    public class AdminRep : IAdminRep
    {
        private readonly DbContainer db;

        public AdminRep(DbContainer db)
        {
            this.db = db;
        }
        public void CreateFeedBack(string Name, string Email, string Content)
        {
            FeedBack feed = new FeedBack()
            {
                Name = Name,
                Email= Email,
                Content = Content
            };
            db.FeedBacks.Add(feed);
            db.SaveChanges();
        }

        public List<FeedBack> GetAllFeedBacks() => db.FeedBacks.ToList();

    }
}
