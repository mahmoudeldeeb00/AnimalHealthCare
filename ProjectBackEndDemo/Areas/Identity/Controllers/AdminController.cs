using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBackEndDemo.Areas.Identity.Models;
using ProjectBackEndDemo.Areas.Identity.Rep;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Controllers
{
    [Area("Identity")]
    [Authorize(Roles="Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> _userManager;
        private readonly IAdminRep adRep;

        public AdminController(RoleManager<IdentityRole> _roleManager, UserManager<AppUser> userManager , IAdminRep adRep)
        {
            roleManager = _roleManager;
            _userManager = userManager;
            this.adRep = adRep;
        }
        

            
        public IActionResult GetAllRoles()
        {
           var RoleList = roleManager.Roles.ToList();
            return View(RoleList);
        }

        public IActionResult CreateRole()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(string rolename)
        {
            if (rolename is not null)
            {
                var result = await roleManager.CreateAsync(new IdentityRole(rolename));
                if (result.Succeeded)
                {
                    return RedirectToAction("GetAllRoles");
                }
                else
                {
                    return View(rolename);
                }
            }



            return View(rolename);
        }




        #region DeleteRole 
        public async Task<IActionResult> DeleteRole(string id)
        {
            var rol = await  roleManager.FindByIdAsync(id);
           var result =await  roleManager.DeleteAsync(rol);
            return RedirectToAction("GetAllRoles");
        }
        #endregion

        # region EditRole
        public async Task<IActionResult> EditRole( string id)
        {
            var EditedRole = await roleManager.FindByIdAsync(id);

            var EditedRoleVM = new EditRoleVM
            {
                Id = EditedRole.Id,
                Name = EditedRole.Name
            };
            return View(EditedRoleVM);
        }
        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleVM model)
        {
            var EditedRole = await roleManager.FindByIdAsync(model.Id);
            EditedRole.Name = model.Name;

           var result = await  roleManager.UpdateAsync(EditedRole);
            if (result.Succeeded)
            {
                return RedirectToAction("GetAllRoles");
            }
            else
            {
                return View(model);
            }
        }
        #endregion

        #region SignUsers To Roles 
        public IActionResult SignUsersToRoles()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUsersToRoles(UserRoleVM UR)
        {

            var User = await _userManager.FindByNameAsync(UR.UserName);
            if (User is not null)
            {

                var result = await _userManager.AddToRoleAsync(User, UR.RoleName);
                if (result.Succeeded)
                {
                    return RedirectToAction("GetAllRoles");
                }
                else
                {
                    ModelState.AddModelError("", "sorry there is error");
                }
            }
            else
            {
                TempData["NoUser"] = "There is no Account to " + UR.UserName;
                return View(UR);
            }


            return View();
        }
#endregion



        [HttpPost]
        public IActionResult AddFeedBack(string Name , string Email , string Content )
        {

            adRep.CreateFeedBack(Name, Email, Content);
            return RedirectToAction("Index","Home",new { area=""});
        }

        public IActionResult ViewFeedBacks() => View(adRep.GetAllFeedBacks());
        

    }
}
