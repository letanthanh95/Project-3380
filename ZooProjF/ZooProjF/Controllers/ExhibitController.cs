using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZooProjF.Models;

namespace ZooProjF.Controllers
{
    //base off of DatabaseController.cs
    //moved to HomeController to get rid of the error on View
    public class ExhibitController : Controller
    {
        //private ExhibitContext Context;

//        void setDBContext()
//        {
//            if (Context == null)
//            {
//                Context = HttpContext.RequestServices.GetService(typeof(ExhibitContext)) as ExhibitContext;
//            }
//        }
//
//        public ActionResult Exhibit()
//        {
//            setDBContext();
//            List<ExhibitModel> exhibit = new List<ExhibitModel>();
//            exhibit = Context.GetAllExhibits();
//            List<ExhibitModel> allExhibit = (from Ex in exhibit
//                select new ExhibitModel
//                {
//                    Exhibit_ID = Ex.Exhibit_ID,
//                    Department_ID = Ex.Department_ID,
//                    Animal_ID = Ex.Animal_ID,
//                    Name = Ex.Name,
//                    Exhibit_Habitat = Ex.Exhibit_Habitat,
//                    Description = Ex.Description,
//                    Image_URL = Ex.Image_URL
//
//                }).ToList<ExhibitModel>();
//            return View(allExhibit);
//        }


    }
}