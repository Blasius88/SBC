using SBC.Entities;
using SBC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SBC.Controllers
{
    //[Authorize(Roles = "admin, user, theacher")]
    public class CoursesController : Controller
    {
        IRepository<CoursesItem> repository;

        public CoursesController(IRepository<CoursesItem> repo)
        {
            repository = repo;
        }
        
        // отображает каталог курсов
        [HttpGet]
        public ActionResult Catalog()
        {
            return View(repository.GetAll());
        }

        //Выводит список курсо, где можно произвести редактирование описание и замены картинки
        // GET: Courses
      //  [Authorize(Roles = "admin")]
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }


        //создания нового курса 
        [HttpGet]
        //[Authorize(Roles = "admin")]
        public ActionResult Create()
        {
            return View(new CoursesItem());
        }

        [HttpPost]
        //[Authorize(Roles = "admin")]
        public ActionResult Create(CoursesItem coursesTest, HttpPostedFileBase imageUpload = null)
        {
            if (ModelState.IsValid)
            {
                if (imageUpload != null)
                {
                    var count = imageUpload.ContentLength;
                    coursesTest.Image = new byte[count];
                    imageUpload.
                        InputStream.
                        Read(coursesTest.Image, 0, (int)count);
                    coursesTest.MineType = imageUpload.ContentType;
                }

                bool check = false;
                try
                {
                    List<CoursesItem> list = new List<CoursesItem>();
                    foreach (var list2 in repository.GetAll())
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
            else return View(coursesTest);
        }


        //редактирование курса
        //[Authorize(Roles = "admin")]
        public ActionResult Edit(int id)
        {
            return View(repository.Get(id));
        }

        // POST: Admin/Edit/5
        [HttpPost]
       // [Authorize(Roles = "admin")]
        public ActionResult Edit(CoursesItem test, HttpPostedFileBase imageUpload = null)
        {
            if (ModelState.IsValid)
            {
                if (imageUpload != null)
                {
                    var count = imageUpload.ContentLength;
                    test.Image = new byte[count];
                    imageUpload
                        .InputStream
                        .Read(test.Image, 0, (int)count);
                    test.MineType = imageUpload.ContentType;
                }
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


        //удаление курса 
        // GET: Admin/Delete/5
        //[Authorize(Roles = "admin")]
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
        //[Authorize(Roles = "admin")]
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


        //получение картинки 
        public async Task<FileResult> GetImage(int id)
        {
            var dish = await repository.GetAsync(id);
            if (dish != null)
            {
                return new FileContentResult(dish.Image, dish.MineType);
            }
            else return null;
        }
    }
}