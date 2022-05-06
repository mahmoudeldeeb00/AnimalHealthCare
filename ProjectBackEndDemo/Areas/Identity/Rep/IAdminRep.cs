using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Rep
{
    public interface IAdminRep
    {

        public void CreateFeedBack(string Name, string Email, string Content);

        public List<FeedBack> GetAllFeedBacks();

    }
}
