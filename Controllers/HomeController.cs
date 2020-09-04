using SBC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Courses()
        {
            return View();
        }
        public ActionResult Biologia() 
        {
            return View();
        }

        public ActionResult Chemistry()
        {
            return View();
        }
    }
}