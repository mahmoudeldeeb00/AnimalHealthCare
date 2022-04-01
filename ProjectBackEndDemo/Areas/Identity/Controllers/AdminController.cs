using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectBackEndDemo.Areas.Identity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Controllers
{
    [Area("Identity")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<AppUser> _userManager;

        public AdminController(RoleManager<IdentityRole> _roleManager, UserManager<AppUser> userManager)
        {
            roleManager = _roleManager;
            _userManager = userManager;
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

            var Roles = roleManager.Roles.ToList();
            var Users = _userManager.Users.ToList();
            ViewBag.Roles = new SelectList(Roles, "Name", "Name");
            ViewBag.Users = new SelectList(Users, "UserName", "UserName");

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

    }
}
