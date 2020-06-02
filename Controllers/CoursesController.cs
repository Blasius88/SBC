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
            return View(courses);
        }

        List<Courses> courses = new List<Courses>
        {
            new Courses
            {
                id =1,
                NameCourses ="Биология",
                Description = ""
            },
            new Courses
            {
                id = 2,
                NameCourses = "Химия",
                Description = ""
            }

        };
    }
}