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

        [HttpGet]
        public ActionResult Test1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test1(Test1 test)
        {
            double res = TestCourses.RezTest1(test);
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

        [HttpPost]
        public ActionResult Test2(Test2 test)
        {
            double res = TestCourses.RezTest2 (test);
            double persentAnswer = Convert.ToDouble(res / 30 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: вирусы и бактериофаги";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: Туорт.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: Бейеринк";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: Покоящаяся";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: Размножение";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: Головку";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: Капсид";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: Бактериофаги";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: Вирион";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный. Верный ответ: Вирулентным";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            return View();
        }

        [HttpGet]
        public ActionResult Test3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test3(Test3 test)
        {
            double res = TestCourses.RezTest3(test);
            double persentAnswer = Convert.ToDouble(res / 50 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 18";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            return View();
        }

        [HttpGet]
        public ActionResult Test4()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test4(Test4 test)
        {
            double res = TestCourses.RezTest4(test);
            double persentAnswer = Convert.ToDouble(res / 72 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            if (!test.answer31)
                ViewBag.Answer31 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer31 = "Ваш ответ верный.";
            if (!test.answer32)
                ViewBag.Answer32 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer32 = "Ваш ответ верный.";
            if (!test.answer33)
                ViewBag.Answer33 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer33 = "Ваш ответ верный.";
            if (!test.answer34)
                ViewBag.Answer34 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer34 = "Ваш ответ верный.";
            if (!test.answer35)
                ViewBag.Answer35 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer35 = "Ваш ответ верный.";
            if (!test.answer36)
                ViewBag.Answer36 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer36 = "Ваш ответ верный.";
            if (!test.answer37)
                ViewBag.Answer37 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer37 = "Ваш ответ верный.";
            if (!test.answer38)
                ViewBag.Answer38 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer38 = "Ваш ответ верный.";
            if (!test.answer39)
                ViewBag.Answer39 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer39 = "Ваш ответ верный.";
            if (!test.answer40)
                ViewBag.Answer40 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer40 = "Ваш ответ верный.";


            return View();
        }

    }
}