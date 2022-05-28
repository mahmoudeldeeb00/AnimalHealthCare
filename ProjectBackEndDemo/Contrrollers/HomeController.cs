using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Contrrollers
{
    
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult ChangeCulture(string culture , string returnUrl)
        {
            Response.Cookies.Append(
        CookieRequestCultureProvider.DefaultCookieName,
        CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
    new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
    );
            return Redirect(returnUrl);
          //  return RedirectToAction("Index");
        }




    }
}
