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
using Microsoft.EntityFrameworkCore;


namespace ZooProjF.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;


        /*private readonly ICustomerRepository _customerRepository;
        public HomeController(ICustomerRepository customerRepository,ILogger<HomeController> logger)
        {
            _customerRepository = new MockCustomerRepository();
            _logger = logger;
        }

        private AppDbContext _context;
       /* public HomeController(AppDbContext context)
        {
            _context = context;
        }*/
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult TicketIndex()
        {
            return View();
        }
        public IActionResult ShopIndex()
        {
            return View();
        }
        public IActionResult Checkout()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
//        public IActionResult Exhibit()
//        {
//            return View();
//        }

        private ExhibitContext Context;
        
        void setDBContext()
        {
            if (Context == null)
            {
                Context = HttpContext.RequestServices.GetService(typeof(ExhibitContext)) as ExhibitContext;
            }
        }
        
        public ActionResult Exhibit()
        {
            setDBContext();
            List<ExhibitModel> exhibit = new List<ExhibitModel>();
            exhibit = Context.GetAllExhibits();
            List<ExhibitModel> allExhibit = (from Ex in exhibit
                select new ExhibitModel
                {
                    Exhibit_ID = Ex.Exhibit_ID,
                    Department_ID = Ex.Department_ID,
                    Animal_ID = Ex.Animal_ID,
                    Name = Ex.Name,
                    Exhibit_Habitat = Ex.Exhibit_Habitat,
                    Description = Ex.Description,
                    Image_URL = Ex.Image_URL

                }).ToList<ExhibitModel>();
            return View(allExhibit);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        

    }
    
}
