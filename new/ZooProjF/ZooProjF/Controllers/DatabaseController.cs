using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
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
//using Stripe;
using ZooProjF.Data;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ZooProjF.Controllers
{
    
    
    public class DatabaseController:Controller
    {
        private CustomerContextcs context;
        void setDbContext()
        {
            if (context==null)
            {
                context = HttpContext.RequestServices.GetService(typeof(CustomerContextcs)) as CustomerContextcs;
            }
        }
        public ActionResult Index()
        {
            setDbContext();
            List<CustomerManagerment> customer = new List<CustomerManagerment>();
            customer = context.GetAllCustomer();
            List<CustomerManagerment> fullcustomer = (from Customer in customer select new CustomerManagerment
            {
                Customer_Id= Customer.Customer_Id,
                First_Name = Customer.First_Name,
                Last_Name = Customer.Last_Name,
                Email = Customer.Email,
                Phone_Number = Customer.Phone_Number,
                Street_Name = Customer.Street_Name,
                Zip_Code = Customer.Zip_Code,
                City = Customer.City,
                State = Customer.State


            }).ToList<CustomerManagerment>();
            return View(fullcustomer);
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm]CustomerManagerment customer)
        {
            try
            {
                // TODO: Add insert logic here

                setDbContext();

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
   

