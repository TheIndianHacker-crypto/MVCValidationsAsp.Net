using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ValidationinMVCLooslyBinding.Models;
using ValidationinMVCLooslyBinding.Controllers;
namespace ValidationinMVCLooslyBinding.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitData(Student _Student)
        {
            if(ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }


        [HttpPost]
        public ActionResult SubmitDataStrongBinding(Student _Student)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            return View("Index");
        }

        [HttpPost]
        public ActionResult SubmitDataValidationSummary(Student _Student)
        {
            if (ModelState.IsValid)
            {
                ModelState.Clear();
                return View();
            }
            return View("Index");
        }
    }
}