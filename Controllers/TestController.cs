using SBC.DAL;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class TestController : Controller
    {
        IRepository<Test> repository;
        IRepository<Question> rep;

        public TestController(IRepository<Test> repo)
        {
            repository = repo;

        }

        // GET: Test
        public ActionResult Index(string id)
        {
            List<Test> list = new List<Test>();
            foreach (var t in repository.GetAll())
            {
                if (Convert.ToInt32(id) == Convert.ToInt32(t.CoursesTest))
                {
                    list.Add(t);
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Test());
        }

        [HttpPost]
        public ActionResult Create(Test test)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    repository.Create(test);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }
            else return View(test);
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View(repository.Get(id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(Test test)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // TODO: Add update logic here
                    repository.Update(test);
                    return RedirectToAction("Index");
                }
                catch
                {
                    return View(test);
                }
            }
            else return View(test);
        }

        public ActionResult Details(string idTest)
        {
            try
            {
                List<Question> list = new List<Question>();
                List<Question> list2 = new List<Question>();
                foreach (var item in rep.GetAll())
                {
                    list.Add(item);
                    
                }
                for (int i = 0; i <= list.Count; i++)
                {
                    if (Convert.ToInt32(list[i].Test) == Convert.ToInt32(idTest))
                    {
                        list2.Add(list[i]);
                    }
                }
                return View(list2);
            }
            catch (Exception e)
            {

                return RedirectToAction("Index", "TesController");
            }
        }

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