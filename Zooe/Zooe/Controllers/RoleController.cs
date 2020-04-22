using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.CodeAnalysis.Differencing;
using Zooe.Views.Role;

namespace Zooe.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await _roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Index", _roleManager.Roles);
        }

        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }
        
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            List<IdentityUser> users = new List<IdentityUser>();
            List<IdentityUser> nonusers = new List<IdentityUser>();

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with ID = {id} cannot be found";
                return View("Index");
            }

//            var model = new IdentityRole
//            {
//                Id = role.Id,
//                Name = role.Name,
//            };


            foreach (var user in _userManager.Users.ToList())
            {
                //if (await _userManager.IsInRoleAsync(user, role.Name))
                //{
                    var result = await _userManager.IsInRoleAsync(user, role.Name) ? users : nonusers;
                    
                    result.Add(user);

                    //model.Users.Add(user.UserName);
                //}
            }

            return View(new EditRole
            {
                Role = role,
                Users = users
            });
            //return View("Index");
        }
        
        [HttpPost]
        public async Task<IActionResult> Update(ModifyRole model)
        {
            IdentityResult result;
            if (ModelState.IsValid)
            {
                foreach (string userId in model.AddIds ?? new string[] { })
                {
                    IdentityUser user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await _userManager.AddToRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
                foreach (string userId in model.DeleteIds ?? new string[] { })
                {
                    IdentityUser user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);
                        if (!result.Succeeded)
                            Errors(result);
                    }
                }
            }
  
            if (ModelState.IsValid)
                return RedirectToAction(nameof(Index));
            else
                return await Edit(model.RoleId);
        }

//        [HttpPost]
//        public async Task<IActionResult> Edit(IdentityRole model)
//        {
//            var role = await _roleManager.FindByIdAsync(model.Id);
//
//            if (role == null)
//            {
//                ViewBag.ErrorMessage = $"Role with ID = {model.Id} cannot be found";
//                return View("Index");
//            }
//            else
//            {
//                role.Name = model.Name;
//                var result = await _roleManager.UpdateAsync(role);
//
//                if (result.Succeeded)
//                {
//                    return RedirectToAction("Index");
//                }
//
//                foreach (var error in result.Errors)
//                {
//                    ModelState.AddModelError("", error.Description);
//                }
//                return View(model);
//            }
//        }
    }
}