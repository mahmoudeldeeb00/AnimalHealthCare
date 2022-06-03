using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.BL.Helpers
{
    public class MailHelper
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;

        public MailHelper(UserManager<AppUser> userManager , SignInManager<AppUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }


        public static bool  SendMail(string email , string title , string body )
        {

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("applicationcura@gmail.com", "#ae244910");

                smtp.Send("applicationcura@gmail.com", email, title, body);
                return true;

          
        }
     
    }
}
