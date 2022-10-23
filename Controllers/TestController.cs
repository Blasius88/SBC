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
        public ActionResult Test1_1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test1_1(Test1_1 test)
        {
            double res = RezTest1_1.Rezultat_Test1_1(test);
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
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            return View();
        }

        [HttpGet]
        public ActionResult Test1_2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test1_2(Test1_2 test)
        {
            double res = RezTest1_2.Rezultat_Test1_2 (test);
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
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный.";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный.";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный.";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный.";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный.";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный.";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
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
            double res = RezTest2.Rezultat_Test2(test);
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
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный.";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный.";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный.";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный.";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный.";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный.";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            if (!test.answer31)
                ViewBag.Answer31 = "Ваш ответ неверный.";
            else
                ViewBag.Answer31 = "Ваш ответ верный.";
            if (!test.answer32)
                ViewBag.Answer32 = "Ваш ответ неверный.";
            else
                ViewBag.Answer32 = "Ваш ответ верный.";
            if (!test.answer33)
                ViewBag.Answer33 = "Ваш ответ неверный.";
            else
                ViewBag.Answer33 = "Ваш ответ верный.";
            if (!test.answer34)
                ViewBag.Answer34 = "Ваш ответ неверный.";
            else
                ViewBag.Answer34 = "Ваш ответ верный.";
            if (!test.answer35)
                ViewBag.Answer35 = "Ваш ответ неверный.";
            else
                ViewBag.Answer35 = "Ваш ответ верный.";
            if (!test.answer36)
                ViewBag.Answer36 = "Ваш ответ неверный.";
            else
                ViewBag.Answer36 = "Ваш ответ верный.";
            if (!test.answer37)
                ViewBag.Answer37 = "Ваш ответ неверный.";
            else
                ViewBag.Answer37 = "Ваш ответ верный.";
            if (!test.answer38)
                ViewBag.Answer38 = "Ваш ответ неверный.";
            else
                ViewBag.Answer38 = "Ваш ответ верный.";
            if (!test.answer39)
                ViewBag.Answer39 = "Ваш ответ неверный.";
            else
                ViewBag.Answer39 = "Ваш ответ верный.";
            if (!test.answer40)
                ViewBag.Answer40 = "Ваш ответ неверный.";
            else
                ViewBag.Answer40 = "Ваш ответ верный.";
            if (!test.answer41)
                ViewBag.Answer41 = "Ваш ответ неверный.";
            else
                ViewBag.Answer41 = "Ваш ответ верный.";
            if (!test.answer42)
                ViewBag.Answer42 = "Ваш ответ неверный.";
            else
                ViewBag.Answer42 = "Ваш ответ верный.";
            if (!test.answer43)
                ViewBag.Answer43 = "Ваш ответ неверный.";
            else
                ViewBag.Answer43 = "Ваш ответ верный.";
            if (!test.answer44)
                ViewBag.Answer44 = "Ваш ответ неверный.";
            else
                ViewBag.Answer44 = "Ваш ответ верный.";
            if (!test.answer45)
                ViewBag.Answer45 = "Ваш ответ неверный.";
            else
                ViewBag.Answer45 = "Ваш ответ верный.";
            if (!test.answer46)
                ViewBag.Answer46 = "Ваш ответ неверный.";
            else
                ViewBag.Answer46 = "Ваш ответ верный.";
            if (!test.answer47)
                ViewBag.Answer47 = "Ваш ответ неверный.";
            else
                ViewBag.Answer47 = "Ваш ответ верный.";
            if (!test.answer48)
                ViewBag.Answer48 = "Ваш ответ неверный.";
            else
                ViewBag.Answer48 = "Ваш ответ верный.";
            if (!test.answer49)
                ViewBag.Answer49 = "Ваш ответ неверный.";
            else
                ViewBag.Answer49 = "Ваш ответ верный.";
            if (!test.answer50)
                ViewBag.Answer50 = "Ваш ответ неверный.";
            else
                ViewBag.Answer50 = "Ваш ответ верный.";
            return View();
        }

        [HttpGet]
        public ActionResult Test3_1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test3_1(Test3_1 test)
        {
            double res = RezTest3_1.Rezultat_Test3_1(test);
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
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный.";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный.";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            if (!test.answer31)
                ViewBag.Answer31 = "Ваш ответ неверный.";
            else
                ViewBag.Answer31 = "Ваш ответ верный.";
            if (!test.answer32)
                ViewBag.Answer32 = "Ваш ответ неверный.";
            else
                ViewBag.Answer32 = "Ваш ответ верный.";
            if (!test.answer33)
                ViewBag.Answer33 = "Ваш ответ неверный.";
            else
                ViewBag.Answer33 = "Ваш ответ верный.";
            if (!test.answer34)
                ViewBag.Answer34 = "Ваш ответ неверный.";
            else
                ViewBag.Answer34 = "Ваш ответ верный.";
            if (!test.answer35)
                ViewBag.Answer35 = "Ваш ответ неверный.";
            else
                ViewBag.Answer35 = "Ваш ответ верный.";
            if (!test.answer36)
                ViewBag.Answer36 = "Ваш ответ неверный.";
            else
                ViewBag.Answer36 = "Ваш ответ верный.";
            if (!test.answer37)
                ViewBag.Answer37 = "Ваш ответ неверный.";
            else
                ViewBag.Answer37 = "Ваш ответ верный.";
            if (!test.answer38)
                ViewBag.Answer38 = "Ваш ответ неверный.";
            else
                ViewBag.Answer38 = "Ваш ответ верный.";
            if (!test.answer39)
                ViewBag.Answer39 = "Ваш ответ неверный.";
            else
                ViewBag.Answer39 = "Ваш ответ верный.";
            if (!test.answer40)
                ViewBag.Answer40 = "Ваш ответ неверный.";
            else
                ViewBag.Answer40 = "Ваш ответ верный.";
            if (!test.answer41)
                ViewBag.Answer41 = "Ваш ответ неверный.";
            else
                ViewBag.Answer41 = "Ваш ответ верный.";
            if (!test.answer42)
                ViewBag.Answer42 = "Ваш ответ неверный.";
            else
                ViewBag.Answer42 = "Ваш ответ верный.";
            if (!test.answer43)
                ViewBag.Answer43 = "Ваш ответ неверный.";
            else
                ViewBag.Answer43 = "Ваш ответ верный.";
            if (!test.answer44)
                ViewBag.Answer44 = "Ваш ответ неверный.";
            else
                ViewBag.Answer44 = "Ваш ответ верный.";
            if (!test.answer45)
                ViewBag.Answer45 = "Ваш ответ неверный.";
            else
                ViewBag.Answer45 = "Ваш ответ верный.";
            if (!test.answer46)
                ViewBag.Answer46 = "Ваш ответ неверный";
            else
                ViewBag.Answer46 = "Ваш ответ верный.";
            if (!test.answer47)
                ViewBag.Answer47 = "Ваш ответ неверный";
            else
                ViewBag.Answer47 = "Ваш ответ верный.";
            if (!test.answer48)
                ViewBag.Answer48 = "Ваш ответ неверный";
            else
                ViewBag.Answer48 = "Ваш ответ верный.";
            if (!test.answer49)
                ViewBag.Answer49 = "Ваш ответ неверный";
            else
                ViewBag.Answer49 = "Ваш ответ верный.";
            if (!test.answer50)
                ViewBag.Answer50 = "Ваш ответ неверный";
            else
                ViewBag.Answer50 = "Ваш ответ верный.";
            if (!test.answer51)
                ViewBag.Answer51 = "Ваш ответ неверный";
            else
                ViewBag.Answer51 = "Ваш ответ верный.";
            if (!test.answer52)
                ViewBag.Answer52 = "Ваш ответ неверный";
            else
                ViewBag.Answer52 = "Ваш ответ верный.";
            if (!test.answer53)
                ViewBag.Answer53 = "Ваш ответ неверный";
            else
                ViewBag.Answer53 = "Ваш ответ верный.";
            if (!test.answer54)
                ViewBag.Answer54 = "Ваш ответ неверный";
            else
                ViewBag.Answer54 = "Ваш ответ верный.";
            if (!test.answer55)
                ViewBag.Answer55 = "Ваш ответ неверный";
            else
                ViewBag.Answer55 = "Ваш ответ верный.";
            if (!test.answer56)
                ViewBag.Answer56 = "Ваш ответ неверный";
            else
                ViewBag.Answer56 = "Ваш ответ верный.";
            if (!test.answer57)
                ViewBag.Answer57 = "Ваш ответ неверный";
            else
                ViewBag.Answer57 = "Ваш ответ верный.";
            if (!test.answer58)
                ViewBag.Answer58 = "Ваш ответ неверный";
            else
                ViewBag.Answer58 = "Ваш ответ верный.";
            if (!test.answer59)
                ViewBag.Answer59 = "Ваш ответ неверный";
            else
                ViewBag.Answer59 = "Ваш ответ верный.";
            if (!test.answer60)
                ViewBag.Answer60 = "Ваш ответ неверный";
            else
                ViewBag.Answer60 = "Ваш ответ верный.";
            if (!test.answer61)
                ViewBag.Answer61 = "Ваш ответ неверный";
            else
                ViewBag.Answer61 = "Ваш ответ верный.";
            if (!test.answer62)
                ViewBag.Answer62 = "Ваш ответ неверный";
            else
                ViewBag.Answer62 = "Ваш ответ верный.";
            if (!test.answer63)
                ViewBag.Answer63 = "Ваш ответ неверный";
            else
                ViewBag.Answer63 = "Ваш ответ верный.";
            if (!test.answer64)
                ViewBag.Answer64 = "Ваш ответ неверный";
            else
                ViewBag.Answer64 = "Ваш ответ верный.";
            if (!test.answer65)
                ViewBag.Answer65 = "Ваш ответ неверный";
            else
                ViewBag.Answer65 = "Ваш ответ верный.";
            if (!test.answer66)
                ViewBag.Answer66 = "Ваш ответ неверный";
            else
                ViewBag.Answer66 = "Ваш ответ верный.";
            if (!test.answer67)
                ViewBag.Answer67 = "Ваш ответ неверный";
            else
                ViewBag.Answer67 = "Ваш ответ верный.";
            if (!test.answer68)
                ViewBag.Answer68 = "Ваш ответ неверный";
            else
                ViewBag.Answer68 = "Ваш ответ верный.";
            if (!test.answer69)
                ViewBag.Answer69 = "Ваш ответ неверный";
            else
                ViewBag.Answer69 = "Ваш ответ верный.";
            if (!test.answer70)
                ViewBag.Answer70 = "Ваш ответ неверный";
            else
                ViewBag.Answer70 = "Ваш ответ верный.";
            if (!test.answer71)
                ViewBag.Answer71 = "Ваш ответ неверный";
            else
                ViewBag.Answer71 = "Ваш ответ верный.";
            if (!test.answer72)
                ViewBag.Answer72 = "Ваш ответ неверный";
            else
                ViewBag.Answer72 = "Ваш ответ верный.";

            return View();
        }

        [HttpGet]
        public ActionResult Test3_2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test3_2(Test3_2 test)
        {
            double res = RezTest3_2.Rezultat_Test3_2(test);
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
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный.";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный.";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";

            return View();
        }

        [HttpGet]
        public ActionResult Test4 ()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test4(Test4 test )
        {
            double res = RezTest4.Rezultat_Test4(test);
            double persentAnswer = Convert.ToDouble(res / 55 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный.";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный.";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            if (!test.answer31)
                ViewBag.Answer31 = "Ваш ответ неверный.";
            else
                ViewBag.Answer31 = "Ваш ответ верный.";
            if (!test.answer32)
                ViewBag.Answer32 = "Ваш ответ неверный.";
            else
                ViewBag.Answer32 = "Ваш ответ верный.";
            if (!test.answer33)
                ViewBag.Answer33 = "Ваш ответ неверный.";
            else
                ViewBag.Answer33 = "Ваш ответ верный.";
            if (!test.answer34)
                ViewBag.Answer34 = "Ваш ответ неверный.";
            else
                ViewBag.Answer34 = "Ваш ответ верный.";
            if (!test.answer35)
                ViewBag.Answer35 = "Ваш ответ неверный.";
            else
                ViewBag.Answer35 = "Ваш ответ верный.";
            if (!test.answer36)
                ViewBag.Answer36 = "Ваш ответ неверный.";
            else
                ViewBag.Answer36 = "Ваш ответ верный.";
            if (!test.answer37)
                ViewBag.Answer37 = "Ваш ответ неверный.";
            else
                ViewBag.Answer37 = "Ваш ответ верный.";
            if (!test.answer38)
                ViewBag.Answer38 = "Ваш ответ неверный.";
            else
                ViewBag.Answer38 = "Ваш ответ верный.";
            if (!test.answer39)
                ViewBag.Answer39 = "Ваш ответ неверный.";
            else
                ViewBag.Answer39 = "Ваш ответ верный.";
            if (!test.answer40)
                ViewBag.Answer40 = "Ваш ответ неверный.";
            else
                ViewBag.Answer40 = "Ваш ответ верный.";
            if (!test.answer41)
                ViewBag.Answer41 = "Ваш ответ неверный.";
            else
                ViewBag.Answer41 = "Ваш ответ верный.";
            if (!test.answer42)
                ViewBag.Answer42 = "Ваш ответ неверный.";
            else
                ViewBag.Answer42 = "Ваш ответ верный.";
            if (!test.answer43)
                ViewBag.Answer43 = "Ваш ответ неверный.";
            else
                ViewBag.Answer43 = "Ваш ответ верный.";
            if (!test.answer44)
                ViewBag.Answer44 = "Ваш ответ неверный.";
            else
                ViewBag.Answer44 = "Ваш ответ верный.";
            if (!test.answer45)
                ViewBag.Answer45 = "Ваш ответ неверный.";
            else
                ViewBag.Answer45 = "Ваш ответ верный.";
            if (!test.answer46)
                ViewBag.Answer46 = "Ваш ответ неверный";
            else
                ViewBag.Answer46 = "Ваш ответ верный.";
            if (!test.answer47)
                ViewBag.Answer47 = "Ваш ответ неверный";
            else
                ViewBag.Answer47 = "Ваш ответ верный.";
            if (!test.answer48)
                ViewBag.Answer48 = "Ваш ответ неверный";
            else
                ViewBag.Answer48 = "Ваш ответ верный.";
            if (!test.answer49)
                ViewBag.Answer49 = "Ваш ответ неверный";
            else
                ViewBag.Answer49 = "Ваш ответ верный.";
            if (!test.answer50)
                ViewBag.Answer50 = "Ваш ответ неверный";
            else
                ViewBag.Answer50 = "Ваш ответ верный.";
            if (!test.answer51)
                ViewBag.Answer51 = "Ваш ответ неверный";
            else
                ViewBag.Answer51 = "Ваш ответ верный.";
            if (!test.answer52)
                ViewBag.Answer52 = "Ваш ответ неверный";
            else
                ViewBag.Answer52 = "Ваш ответ верный.";
            if (!test.answer53)
                ViewBag.Answer53 = "Ваш ответ неверный";
            else
                ViewBag.Answer53 = "Ваш ответ верный.";
            if (!test.answer54)
                ViewBag.Answer54 = "Ваш ответ неверный";
            else
                ViewBag.Answer54 = "Ваш ответ верный.";
            if (!test.answer55)
                ViewBag.Answer55 = "Ваш ответ неверный";
            else
                ViewBag.Answer55 = "Ваш ответ верный.";

            return View();
        }

        [HttpGet]
        public ActionResult Test5()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test5( Test5 test)
        {
            double res = RezTest5.Rezultat_Test5(test);
            double persentAnswer = Convert.ToDouble(res / 58 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный.";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный.";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный.";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный.";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный.";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный.";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный.";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный.";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный.";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.answer24)
                ViewBag.Answer24 = "Ваш ответ неверный.";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.answer25)
                ViewBag.Answer25 = "Ваш ответ неверный.";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.answer26)
                ViewBag.Answer26 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.answer27)
                ViewBag.Answer27 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.answer28)
                ViewBag.Answer28 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.answer29)
                ViewBag.Answer29 = "Ваш ответ неверный. ";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.answer30)
                ViewBag.Answer30 = "Ваш ответ неверный.";
            else
                ViewBag.Answer30 = "Ваш ответ верный.";
            if (!test.answer31)
                ViewBag.Answer31 = "Ваш ответ неверный.";
            else
                ViewBag.Answer31 = "Ваш ответ верный.";
            if (!test.answer32)
                ViewBag.Answer32 = "Ваш ответ неверный.";
            else
                ViewBag.Answer32 = "Ваш ответ верный.";
            if (!test.answer33)
                ViewBag.Answer33 = "Ваш ответ неверный.";
            else
                ViewBag.Answer33 = "Ваш ответ верный.";
            if (!test.answer34)
                ViewBag.Answer34 = "Ваш ответ неверный.";
            else
                ViewBag.Answer34 = "Ваш ответ верный.";
            if (!test.answer35)
                ViewBag.Answer35 = "Ваш ответ неверный.";
            else
                ViewBag.Answer35 = "Ваш ответ верный.";
            if (!test.answer36)
                ViewBag.Answer36 = "Ваш ответ неверный.";
            else
                ViewBag.Answer36 = "Ваш ответ верный.";
            if (!test.answer37)
                ViewBag.Answer37 = "Ваш ответ неверный.";
            else
                ViewBag.Answer37 = "Ваш ответ верный.";
            if (!test.answer38)
                ViewBag.Answer38 = "Ваш ответ неверный.";
            else
                ViewBag.Answer38 = "Ваш ответ верный.";
            if (!test.answer39)
                ViewBag.Answer39 = "Ваш ответ неверный.";
            else
                ViewBag.Answer39 = "Ваш ответ верный.";
            if (!test.answer40)
                ViewBag.Answer40 = "Ваш ответ неверный.";
            else
                ViewBag.Answer40 = "Ваш ответ верный.";
            if (!test.answer41)
                ViewBag.Answer41 = "Ваш ответ неверный.";
            else
                ViewBag.Answer41 = "Ваш ответ верный.";
            if (!test.answer42)
                ViewBag.Answer42 = "Ваш ответ неверный.";
            else
                ViewBag.Answer42 = "Ваш ответ верный.";
            if (!test.answer43)
                ViewBag.Answer43 = "Ваш ответ неверный.";
            else
                ViewBag.Answer43 = "Ваш ответ верный.";
            if (!test.answer44)
                ViewBag.Answer44 = "Ваш ответ неверный.";
            else
                ViewBag.Answer44 = "Ваш ответ верный.";
            if (!test.answer45)
                ViewBag.Answer45 = "Ваш ответ неверный.";
            else
                ViewBag.Answer45 = "Ваш ответ верный.";
            if (!test.answer46)
                ViewBag.Answer46 = "Ваш ответ неверный";
            else
                ViewBag.Answer46 = "Ваш ответ верный.";
            if (!test.answer47)
                ViewBag.Answer47 = "Ваш ответ неверный";
            else
                ViewBag.Answer47 = "Ваш ответ верный.";
            if (!test.answer48)
                ViewBag.Answer48 = "Ваш ответ неверный";
            else
                ViewBag.Answer48 = "Ваш ответ верный.";
            if (!test.answer49)
                ViewBag.Answer49 = "Ваш ответ неверный";
            else
                ViewBag.Answer49 = "Ваш ответ верный.";
            if (!test.answer50)
                ViewBag.Answer50 = "Ваш ответ неверный";
            else
                ViewBag.Answer50 = "Ваш ответ верный.";
            if (!test.answer51)
                ViewBag.Answer51 = "Ваш ответ неверный";
            else
                ViewBag.Answer51 = "Ваш ответ верный.";
            if (!test.answer52)
                ViewBag.Answer52 = "Ваш ответ неверный";
            else
                ViewBag.Answer52 = "Ваш ответ верный.";
            if (!test.answer53)
                ViewBag.Answer53 = "Ваш ответ неверный";
            else
                ViewBag.Answer53 = "Ваш ответ верный.";
            if (!test.answer54)
                ViewBag.Answer54 = "Ваш ответ неверный";
            else
                ViewBag.Answer54 = "Ваш ответ верный.";
            if (!test.answer55)
                ViewBag.Answer55 = "Ваш ответ неверный";
            else
                ViewBag.Answer55 = "Ваш ответ верный.";
            if (!test.answer56)
                ViewBag.Answer56 = "Ваш ответ неверный";
            else
                ViewBag.Answer56 = "Ваш ответ верный.";
            if (!test.answer57)
                ViewBag.Answer57 = "Ваш ответ неверный";
            else
                ViewBag.Answer57 = "Ваш ответ верный.";
            if (!test.answer58)
                ViewBag.Answer58 = "Ваш ответ неверный";
            else
                ViewBag.Answer58 = "Ваш ответ верный.";


            return View();
        }
    }
}