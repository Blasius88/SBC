using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SBC.DAL;

namespace SBC.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Biologia()
        {
            return View();
        }

        public ActionResult Сhemistry()
        {
            return View();
        }
    }
}