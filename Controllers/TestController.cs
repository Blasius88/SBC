using SBC.DAL;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class TestController : Controller
    {
        IRepository<TestItem> repository;
        IRepository<QuestionItem> rep;
        public TestController(IRepository<TestItem> repo)
        {
            repository = repo;

        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Index(CoursesItem coursesTest)
        {
            List<TestItem> list = new List<TestItem>();
            foreach (var t in repository.GetAll())
            {
                if (Convert.ToInt32(coursesTest.id) == Convert.ToInt32(t.Courses))
                {
                    list.Add(t);
                }
            }
            return View(list);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new TestItem());
        }

        [HttpPost]
        public ActionResult Create(TestItem test)
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
        public ActionResult Edit(TestItem test)
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
                List<QuestionItem> list = new List<QuestionItem>();
                List<QuestionItem> list2 = new List<QuestionItem>();
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