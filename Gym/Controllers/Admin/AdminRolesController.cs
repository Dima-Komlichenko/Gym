using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gym.Data;
using Gym.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Gym.Controllers.Admin
{
    [Authorize (Roles ="Admin")]
    public class AdminRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AdminRolesController(
                    RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }

        // GET:AdminRoles
        public IActionResult Index()
        {
            return View("~/Views/AdminRoles/Index.cshtml", _roleManager.Roles.ToList());
        }

        // GET:AdminRoles/Create
        public IActionResult Create()
        {
            return View("~/Views/AdminRoles/Create.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            if (!string.IsNullOrEmpty(name))
            {
                IdentityResult result = await _roleManager.CreateAsync(new IdentityRole(name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleIndex");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(name);
        }
    }
}
