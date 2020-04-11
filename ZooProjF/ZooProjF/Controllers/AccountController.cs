using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ZooProjF.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ZooProjF.ViewModels;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Http;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZooProjF.Controllers
{
   
    public class AccountController : Controller
    {
        private readonly AppDbContext _dbContext;
        private AppDbContext context;

        public AccountController(AppDbContext context)
        {
            _dbContext = context;
        }

        void setDbContext()
        {
            if (context==null)
            {
                context = HttpContext.RequestServices.GetService(typeof(AppDbContext)) as AppDbContext;
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if(ModelState.IsValid)
            {
                var customermanagerment = await _dbContext.CustomerManagerment.FirstOrDefaultAsync
                    (m => m.Email==model.Email &&m.Password==model.Password);
                if(customermanagerment==null)
                {
                    ModelState.AddModelError("Password", "Wrong Password.");
                    return View("Login");
                }
                HttpContext.Session.SetString("Customer_Id", CustomerManagerment.Customer_Id);
            }
            else
            {
                return View("Login");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult>Resgister(RegisterModel model)
        {
            if(ModelState.IsValid)
            {
                CustomerManagerment customer = new CustomerManagerment
                {
                    Customer_ID = model.Customer_ID,
                    First_Name = model.First_name,
                    Last_Name = model.Last_Name,
                    Phone_Number = model.Phone_Number,
                    Email = model.Email,
                    Street_Name = model.Street_Name,
                    Zip_Code = model.Zip_Code,
                    City = model.City,
                    State = model.State,
                    Password = model.Password,
                };
                _dbContext.Add(customer);
                await _dbContext.SaveChangesAsync();

            }
            else
            {
                return View("Register");
            }
            return RedirectToAction("Index", "Account");
        }

        public IActionResult Register()
        {
            ViewData["Message"] = "Registration Page";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Index");
        }

        public void ValidationMessage(string key,string alert,string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);

            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }
        }
    }
    
    
}
