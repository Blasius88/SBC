using SBC.DAL;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class CoursesTestController : Controller
    {
        IRepository<CoursesTest> repository;
       
        public CoursesTestController(IRepository<CoursesTest> repo)
        {
            repository = repo;
        }

        // GET: Test
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new CoursesTest());
        }

        [HttpPost]
        public ActionResult Create(CoursesTest coursesTest)
        {
            bool check = false;
            try
            {
               List<CoursesTest> list = new List<CoursesTest>();
               foreach ( var list2 in repository.GetAll())
                {
                    list.Add(list2);
                }
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].NameCourses == coursesTest.NameCourses)
                    {
                        check = false;
                        break;

                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    repository.Create(coursesTest);
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Create");
                }
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

        public ActionResult Edit(int id)
        {
            return RedirectToAction("Index", "TestController", id);
        }

        

        //[Authorize(Roles ="admin")]
        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

 //       [Authorize(Roles = "admin")]
        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}