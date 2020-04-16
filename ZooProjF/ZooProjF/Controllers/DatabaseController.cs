
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using ZooProjF.Data;
using ZooProjF.Models;

namespace ZooProjF.Controllers
{
    public class DatabaseController : Controller
    {
        private CustomerContext context;

        public void SetDbContext()
        {
            if (context == null)
            {
                context = HttpContext.RequestServices.GetService(typeof(CustomerContext)) as CustomerContext;
            }
        }

        public ActionResult Index()
        {
            SetDbContext();
            List<CustomerManagement> customer = new List<CustomerManagement>();
            customer = context.GetAllCustomer();
            List<CustomerManagement> fullcustomer = (from Customer in customer
                                                     select new CustomerManagement
                                                     {
                                                         CustomerMangagementId = Customer.CustomerMangagementId,
                                                         First_Name = Customer.First_Name,
                                                         Last_Name = Customer.Last_Name,
                                                         Email = Customer.Email,
                                                         Phone_Number = Customer.Phone_Number,
                                                         Street_Name = Customer.Street_Name,
                                                         Zip_Code = Customer.Zip_Code,
                                                         City = Customer.City,
                                                         State = Customer.State

                                                     }).ToList<CustomerManagement>();
            return View(fullcustomer);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]CustomerManagement customer)
        {
            try
            {
                // TODO: Add insert logic here

                SetDbContext();

                int status = context.AddCustomerToDB(customer);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}