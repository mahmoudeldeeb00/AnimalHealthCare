using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Controllers
{
    public class AccountController : Controller
    {

        #region constructor 
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManaeger;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManaeger)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManaeger = roleManaeger;
        }
        #endregion



        #region registration 

        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Registration( RegistrationVM regModel)
        {
            if (ModelState.IsValid)
            {
                AppUser NewUser = new AppUser()
                {
                    UserName = regModel.UserName,
                    Email = regModel.Email
                };
                var result = await userManager.CreateAsync(NewUser, regModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
                else
                {
                    foreach(var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(regModel);
        }


        #endregion


        #region Login 
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Login(LoginVM lgmodel)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(lgmodel.Email, lgmodel.Password, lgmodel.RemmemberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login Data (User Name or Password ) ");

                }
            }



            return View(lgmodel);
        }




        #endregion


        #region signOut 
        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        #endregion




    }
}
