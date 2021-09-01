using SBC.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using SBC.Entities;
using SBC.Models.Test.Test1;

namespace SBC.Controllers
{
    //необходимо сделать так что бы ответы считывала с бд, давала им сравнение и выводила результат 
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

        [HttpGet]
        public ActionResult Test1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test1(Test1 test)
        {
            double res = TestCourses.Test(test);
            double persentAnswer = Convert.ToDouble(res / 24 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 1.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 2.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 1.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 1.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 4.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 4.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: Карл Линней.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: Вид.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: Империя.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: Семейства";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: Классы";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: Отделы";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: Царство";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: Отряд";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: Порядок";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: Вирусы";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: Прокариоты";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: Эукариоты";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: 1832596";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: 1834576";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            return View();
        }

        [HttpGet]
        public ActionResult Test2()
        {
            return View();
        }

        //[HttpPost]
        //public ActionResult Test2(Test2 test)
        //{
        //    double res = TestCourses.Test2(test);
        //    double persentAnswer = Convert.ToDouble(res / 30 * 100);
        //    if (res != 0)
        //    {
        //        ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
        //    }
        //    else
        //    {
        //        ViewBag.Result = "У вас нет правильных ответов";
        //    }
        //    if (!test.check1)
        //        ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer1 = "Ваш ответ верный.";
        //    if (!test.check2)
        //        ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer2 = "Ваш ответ верный.";
        //    if (!test.check3)
        //        ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer3 = "Ваш ответ верный.";
        //    if (!test.check4)
        //        ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer4 = "Ваш ответ верный.";
        //    if (!test.check5)
        //        ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer2 = "Ваш ответ верный.";
        //    if (!test.check6)
        //        ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer6 = "Ваш ответ верный.";
        //    if (!test.check7)
        //        ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer7 = "Ваш ответ верный.";
        //    if (!test.check8)
        //        ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer8 = "Ваш ответ верный.";
        //    if (!test.check9)
        //        ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer9 = "Ваш ответ верный.";
        //    if (!test.check10)
        //        ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 4";
        //    else
        //        ViewBag.Answer10 = "Ваш ответ верный.";
        //    if (!test.check11)
        //        ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer11 = "Ваш ответ верный.";
        //    if (!test.check12)
        //        ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer12 = "Ваш ответ верный.";
        //    if (!test.check13)
        //        ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer13 = "Ваш ответ верный.";
        //    if (!test.check14)
        //        ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 4";
        //    else
        //        ViewBag.Answer14 = "Ваш ответ верный.";
        //    if (!test.check15)
        //        ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer15 = "Ваш ответ верный.";
        //    if (!test.check16)
        //        ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer16 = "Ваш ответ верный.";
        //    if (!test.check17)
        //        ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer17 = "Ваш ответ верный.";
        //    if (!test.check18)
        //        ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 4";
        //    else
        //        ViewBag.Answer18 = "Ваш ответ верный.";
        //    if (!test.check19)
        //        ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer19 = "Ваш ответ верный.";
        //    if (!test.check20)
        //        ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer20 = "Ваш ответ верный.";
        //    if (!test.check21)
        //        ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: вирусы и бактериофаги";
        //    else
        //        ViewBag.Answer21 = "Ваш ответ верный.";
        //    if (!test.check22)
        //        ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: Туорт.";
        //    else
        //        ViewBag.Answer22 = "Ваш ответ верный.";
        //    if (!test.check23)
        //        ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: Бейеринк";
        //    else
        //        ViewBag.Answer23 = "Ваш ответ верный.";
        //    if (!test.check24)
        //        ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: Покоящаяся";
        //    else
        //        ViewBag.Answer24 = "Ваш ответ верный.";
        //    if (!test.check25)
        //        ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: Размножение";
        //    else
        //        ViewBag.Answer25 = "Ваш ответ верный.";
        //    if (!test.check26)
        //        ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: Головку";
        //    else
        //        ViewBag.Answer26 = "Ваш ответ верный.";
        //    if (!test.check27)
        //        ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: Капсид";
        //    else
        //        ViewBag.Answer27 = "Ваш ответ верный.";
        //    if (!test.check28)
        //        ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: Бактериофаги";
        //    else
        //        ViewBag.Answer28 = "Ваш ответ верный.";
        //    if (!test.check29)
        //        ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: Вирион";
        //    else
        //        ViewBag.Answer29 = "Ваш ответ верный.";
        //    if (!test.check30)
        //        ViewBag.Answer30 = "Ваш ответ неверный. Верный ответ: Вирулентным";
        //    else
        //        ViewBag.Answer30 = "Ваш ответ верный.";
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Test3()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Test3(Test3 test)
        //{
        //    double res = TestCourses.Test3(test);
        //    double persentAnswer = Convert.ToDouble(res / 50 * 100);
        //    if (res != 0)
        //    {
        //        ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
        //    }
        //    else
        //    {
        //        ViewBag.Result = "У вас нет правильных ответов";
        //    }
        //    if (!test.check1)
        //        ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer1 = "Ваш ответ верный.";
        //    if (!test.check2)
        //        ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer2 = "Ваш ответ верный.";
        //    if (!test.check3)
        //        ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer3 = "Ваш ответ верный.";
        //    if (!test.check4)
        //        ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer4 = "Ваш ответ верный.";
        //    if (!test.check5)
        //        ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer2 = "Ваш ответ верный.";
        //    if (!test.check6)
        //        ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer6 = "Ваш ответ верный.";
        //    if (!test.check7)
        //        ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer7 = "Ваш ответ верный.";
        //    if (!test.check8)
        //        ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer8 = "Ваш ответ верный.";
        //    if (!test.check9)
        //        ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 4";
        //    else
        //        ViewBag.Answer9 = "Ваш ответ верный.";
        //    if (!test.check10)
        //        ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer10 = "Ваш ответ верный.";
        //    if (!test.check11)
        //        ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer11 = "Ваш ответ верный.";
        //    if (!test.check12)
        //        ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer12 = "Ваш ответ верный.";
        //    if (!test.check13)
        //        ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer13 = "Ваш ответ верный.";
        //    if (!test.check14)
        //        ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer14 = "Ваш ответ верный.";
        //    if (!test.check15)
        //        ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 4";
        //    else
        //        ViewBag.Answer15 = "Ваш ответ верный.";
        //    if (!test.check16)
        //        ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer16 = "Ваш ответ верный.";
        //    if (!test.check17)
        //        ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer17 = "Ваш ответ верный.";
        //    if (!test.check18)
        //        ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 18";
        //    else
        //        ViewBag.Answer18 = "Ваш ответ верный.";
        //    if (!test.check19)
        //        ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer19 = "Ваш ответ верный.";
        //    if (!test.check20)
        //        ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer20 = "Ваш ответ верный.";
        //    if (!test.check21)
        //        ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer21 = "Ваш ответ верный.";
        //    if (!test.check22)
        //        ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer22 = "Ваш ответ верный.";
        //    if (!test.check23)
        //        ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer23 = "Ваш ответ верный.";
        //    if (!test.check24)
        //        ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer24 = "Ваш ответ верный.";
        //    if (!test.check25)
        //        ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: 3";
        //    else
        //        ViewBag.Answer25 = "Ваш ответ верный.";
        //    if (!test.check26)
        //        ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer26 = "Ваш ответ верный.";
        //    if (!test.check27)
        //        ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: 1";
        //    else
        //        ViewBag.Answer27 = "Ваш ответ верный.";
        //    if (!test.check28)
        //        ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: 5";
        //    else
        //        ViewBag.Answer28 = "Ваш ответ верный.";
        //    if (!test.check29)
        //        ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: 2";
        //    else
        //        ViewBag.Answer29 = "Ваш ответ верный.";
        //    if (!test.check30)
        //        ViewBag.Answer30 = "Ваш ответ неверный. Верный ответ: 4";
        //    else
        //        ViewBag.Answer30 = "Ваш ответ верный.";
        //    return View();
        //}

        //[HttpGet]
        //public ActionResult Test4()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Test4(Test4 test)
        //{
        //    return View();
        //}

    }
}