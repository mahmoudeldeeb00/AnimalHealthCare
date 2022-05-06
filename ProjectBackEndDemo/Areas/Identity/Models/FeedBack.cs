using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class FeedBack
    {


        public int Id { get; set; }
        public string  Name { get; set; }
        public string Email { get; set; }
        public string Content { get; set; }

    }
}
