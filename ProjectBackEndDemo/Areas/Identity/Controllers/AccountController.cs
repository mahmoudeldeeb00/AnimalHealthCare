using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ProjectBackEndDemo.Areas.Identity.Controllers
{
    [Area("Identity")]
    
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
                var IsExist = await userManager.FindByNameAsync(regModel.UserName);
                if(IsExist == null)
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
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "User Name is Already Exist ");

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
                //var user = await userManager.FindByEmailAsync(lgmodel.Email);
                var result = await signInManager.PasswordSignInAsync(lgmodel.UserName, lgmodel.Password, lgmodel.RemmemberMe, false);

                if (result.Succeeded)
                {
                      return RedirectToAction("Index", "Home" ,new { area=""});
                   // return View("~/Views/Home/Index.cshtml");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Login Data (User Name or Password ) ");

                }
            }



            return View(lgmodel);
        }




        #endregion


        #region logout 
        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            await signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
        #endregion



        #region Edit Profile 

        public async Task<IActionResult> EditProfile(string id )
        {
            var currentUser = await userManager.FindByIdAsync(id);

            EditProfileVM u = new EditProfileVM()
            {
                Id = currentUser.Id ,
                UserName = currentUser.UserName,
                BirthDay = currentUser.BirthDay,
                Email = currentUser.Email,
                PhoneNumber = currentUser.PhoneNumber,
                ProfilePic = currentUser.ProfilePic
            };

            return View(u);
        }


        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileVM prmodel )
        {

            if (ModelState.IsValid)
            {
                var User = await userManager.FindByIdAsync(prmodel.Id);

                User.UserName = prmodel.UserName;
                User.Email = prmodel.Email;
                User.BirthDay = prmodel.BirthDay;
                User.PhoneNumber = prmodel.PhoneNumber;



                string FilePath = Directory.GetCurrentDirectory() + "/wwwroot/Files/UsersProfilePictures";
                string FileName = User.Id + prmodel.ProfilePicture.FileName;
                string FinalPath = Path.Combine(FilePath, FileName);
                

                using (var stream = new FileStream(FinalPath, FileMode.Create))
                {
                    prmodel.ProfilePicture.CopyTo(stream);
                }


                User.ProfilePic = FileName;

                var result = await userManager.UpdateAsync(User);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    foreach(var error in result.Errors){
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(prmodel);
                }






            }

            return View(prmodel);




        }

        #endregion
        #region view profile 
        
        public async Task<IActionResult> ViewProfile(string id)
        {
            var currentUser = await userManager.FindByIdAsync(id);

            EditProfileVM u = new EditProfileVM()
            {
                Id = currentUser.Id,
                UserName = currentUser.UserName,
                BirthDay = currentUser.BirthDay,
                Email = currentUser.Email,
                PhoneNumber = currentUser.PhoneNumber,
                ProfilePic = currentUser.ProfilePic,
                
            };

            return View(u);
        }

        #endregion
    }
}
