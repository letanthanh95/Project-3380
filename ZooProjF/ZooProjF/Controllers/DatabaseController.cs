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
using Stripe;

namespace ZooProjF.Controllers
{
    
    public class DatabaseController
    {
        /*
        private AppDbContext context;
        void setDbContext()
        {
            if (context==null)
            {
                context = HttpContext.RequestServices.GetService(typeof(AppDbContext)) as AppDbContext;
            }
        }
        public IActionResult Index()
        {
            setDbContext();
        }
        */
        List<CustomerManager> list = new List<CustomerManager>();
        //Customers=context.
    }
}
