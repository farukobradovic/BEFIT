using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BEFIT.Models;
using BEFIT.ViewModels.Administration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BEFIT.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdministrationController : Controller
    {
        private readonly RoleManager<Role> roleManager;
  
        public AdministrationController(RoleManager<Role> roleManager)
        {
            this.roleManager = roleManager;
        }

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                Role identityRole = new Role
                {
                    Name = model.RoleName,
                    DateCreated = DateTime.Now,
                    Description = model.Description
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole);

                if (result.Succeeded)
                {
                    return RedirectToAction("DisplayRoles", "Administration");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult DisplayRoles()
        {
            var roles = roleManager.Roles;

            return View(roles);
        }
        [HttpPost]
        public async Task<IActionResult> DisplayRoles(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
                return StatusCode(418);

            var result = await roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                return RedirectToAction("DisplayRoles", "Administration");
            }
            return View();
        }
    }
}