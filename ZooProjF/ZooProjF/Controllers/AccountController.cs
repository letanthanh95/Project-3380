using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using System.Diagnostics;
using System.Threading.Tasks;
using ZooProjF.Models;
using ZooProjF.ViewModels;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ZooProjF.Controllers
{
    public class AccountController : Controller
    {
        private AppDbContext _dbContext;
        private AppDbContext context;

        public AccountController(AppDbContext context)
        {
            _dbContext = context;
        }

        public void setDbContext()
        {
            if (context == null)
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
        public async Task<IActionResult> Login(CustomerManagement model)
        {
            if (ModelState.IsValid)
            {
                var customermanagement = await _dbContext.CustomerManagement.FirstOrDefaultAsync
                    (m => m.Email == model.Email && m.Password == model.Password);

                if (customermanagement == null)
                {
                    ModelState.AddModelError("Password", "Wrong Password.");
                    return View("Login");
                }
                HttpContext.Session.SetString("First_Name", customermanagement.First_Name);
            }
            else
            {
                return View("Login");
            }
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Resgister(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                CustomerManagement customer = new CustomerManagement
                {
                    CustomerMangagementId = model.Customer_Id,
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

        public void ValidationMessage(string key, string alert, string value)
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
