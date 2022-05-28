using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.BL.Helpers;
using ProjectBackEndDemo.DAL.DataBase;
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
        private readonly DbContainer db;
       
     

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManaeger, DbContainer db)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManaeger = roleManaeger;
            this.db = db;
           
    
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
        
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Login( string returnUrl, LoginVM lgmodel  )
        {
            if (ModelState.IsValid)
            {
                
                var result = await signInManager.PasswordSignInAsync(lgmodel.UserName, lgmodel.Password, lgmodel.RemmemberMe, false);

                if (result.Succeeded)
                {
                    if (!String.IsNullOrWhiteSpace(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home", new { area = "" });

                }
                ModelState.AddModelError("", "Invalid Login Data (User Name or Password ) ");
                
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
                Id = currentUser.Id,
                UserName = currentUser.UserName,
                BirthDay = currentUser.BirthDay,
                Email = currentUser.Email,
                PhoneNumber = currentUser.PhoneNumber,
            
                AnimalId = (int)currentUser.AnimalId,
                Gmail = currentUser.Gmail
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
                User.Gmail = prmodel.Gmail.Trim();
                User.AnimalId = prmodel.AnimalId;            
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
      
        // profile Pictures 
        public async Task<IActionResult> EditProfilePicture(string id)
        {
            var currentUser = await userManager.FindByIdAsync(id);

            EditProfilePictureVM pic = new EditProfilePictureVM()
            {
                Id = currentUser.Id,
                ProfilePic = currentUser.ProfilePic

            };

            return View(pic);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfilePicture(EditProfilePictureVM model)
        {
            if (ModelState.IsValid)
            {
                var User = await userManager.FindByIdAsync(model.Id);


           

                User.ProfilePic = SaveFileHelper.SaveProfilePicture(User.Id,model.ProfilePicture);

                var result = await userManager.UpdateAsync(User);

                if (result.Succeeded)
                {

                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }
              

            }
            return View(model);

        }
        #endregion
      
        
        #region forget password 


        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgetPassword( ForgetPasswordVM model)
        {


            if (ModelState.IsValid)
            {
                
                var user = await userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                   var useremail = user.Email;

                    var token = await userManager.GeneratePasswordResetTokenAsync(user);
                    
                    var passwordResetLink = Url.Action("ResetPassword", "Account", new { area = "Identity", Email = useremail, Token = token }, Request.Scheme);


                    MailHelper.SendMail(user.Gmail, "Cura Account Reset Link", passwordResetLink);

                    return RedirectToAction("ConfirmResetPassword");
                }
                ModelState.AddModelError("", "There is no account with this UserName");
                return View();

            }

            return View(model);

          
        }

        public IActionResult ConfirmForgetPassword()
        {
            return View();
        }


        public IActionResult ResetPassword(string Email, string Token)
        {
            if (Email == null || Token == null)
            {
                ModelState.AddModelError("", "invalid email or Token ");

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user != null)
                {
                    var result = await userManager.ResetPasswordAsync(user, model.Token, model.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("ConfirmResetPassword");
                    }

                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(model);
                }

                return RedirectToAction("ConfirmResetPassword");

            }
            return View(model);
        }

       public IActionResult ConfirmResetPassword()
        {

            return View();
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
                AnimalId = (int)currentUser.AnimalId,
                Gmail = currentUser.Gmail
             
            };

            u.AnimalName = db.Animals.Where(a => a.Id == currentUser.AnimalId).Select(a => a.Name).FirstOrDefault();

            return View(u);
        }

        #endregion
    }
}
