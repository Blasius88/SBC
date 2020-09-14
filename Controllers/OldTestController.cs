using SBC.DAL;
using System;
using System.Web.Mvc;

namespace SBC.Controllers
{
    public class OldTestController : Controller
    {
        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize]
        public ActionResult Biologia()
        {
            return View();
        }

        [Authorize]
        public ActionResult Сhemistry()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Test1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Test1(Test1 test1)
        {
            double res = TestCourses.Test1(test1);
            double persentAnswer = Convert.ToDouble(res / 24 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test1.answer1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 1.";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test1.answer2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test1.answer3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test1.answer4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test1.answer5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 2.";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test1.answer6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 1.";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test1.answer7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 3.";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test1.answer8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 1.";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test1.answer9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 4.";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test1.answer10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 4.";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test1.answer11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: Карл Линней.";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test1.answer12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: Вид.";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test1.answer13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: Империя.";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test1.answer14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: Семейства";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test1.answer15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: Классы";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test1.answer16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: Отделы";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test1.answer17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: Царство";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test1.answer18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: Отряд";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test1.answer19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: Порядок";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test1.answer20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: Вирусы";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test1.answer21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: Прокариоты";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test1.answer22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: Эукариоты";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test1.answer23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: 1832596";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test1.answer24)
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
            double res = TestCourses.Test2(test);
            double persentAnswer = Convert.ToDouble(res / 30 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.check1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.check2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.check3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.check4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.check5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.check6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.check7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.check8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.check9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.check10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.check11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.check12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.check13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.check14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.check15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.check16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.check17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.check18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.check19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.check20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.check21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: вирусы и бактериофаги";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.check22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: Туорт.";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.check23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: Бейеринк";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.check24)
                ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: Покоящаяся";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.check25)
                ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: Размножение";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.check26)
                ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: Головку";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.check27)
                ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: Капсид";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.check28)
                ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: Бактериофаги";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.check29)
                ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: Вирион";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.check30)
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
            double res = TestCourses.Test3(test);
            double persentAnswer = Convert.ToDouble(res / 50 * 100);
            if (res != 0)
            {
                ViewBag.Result = "Процент правильных ответов: " + Math.Round(persentAnswer, 2) + " %";
            }
            else
            {
                ViewBag.Result = "У вас нет правильных ответов";
            }
            if (!test.check1)
                ViewBag.Answer1 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer1 = "Ваш ответ верный.";
            if (!test.check2)
                ViewBag.Answer2 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.check3)
                ViewBag.Answer3 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer3 = "Ваш ответ верный.";
            if (!test.check4)
                ViewBag.Answer4 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer4 = "Ваш ответ верный.";
            if (!test.check5)
                ViewBag.Answer5 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer2 = "Ваш ответ верный.";
            if (!test.check6)
                ViewBag.Answer6 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer6 = "Ваш ответ верный.";
            if (!test.check7)
                ViewBag.Answer7 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer7 = "Ваш ответ верный.";
            if (!test.check8)
                ViewBag.Answer8 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer8 = "Ваш ответ верный.";
            if (!test.check9)
                ViewBag.Answer9 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer9 = "Ваш ответ верный.";
            if (!test.check10)
                ViewBag.Answer10 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer10 = "Ваш ответ верный.";
            if (!test.check11)
                ViewBag.Answer11 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer11 = "Ваш ответ верный.";
            if (!test.check12)
                ViewBag.Answer12 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer12 = "Ваш ответ верный.";
            if (!test.check13)
                ViewBag.Answer13 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer13 = "Ваш ответ верный.";
            if (!test.check14)
                ViewBag.Answer14 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer14 = "Ваш ответ верный.";
            if (!test.check15)
                ViewBag.Answer15 = "Ваш ответ неверный. Верный ответ: 4";
            else
                ViewBag.Answer15 = "Ваш ответ верный.";
            if (!test.check16)
                ViewBag.Answer16 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer16 = "Ваш ответ верный.";
            if (!test.check17)
                ViewBag.Answer17 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer17 = "Ваш ответ верный.";
            if (!test.check18)
                ViewBag.Answer18 = "Ваш ответ неверный. Верный ответ: 18";
            else
                ViewBag.Answer18 = "Ваш ответ верный.";
            if (!test.check19)
                ViewBag.Answer19 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer19 = "Ваш ответ верный.";
            if (!test.check20)
                ViewBag.Answer20 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer20 = "Ваш ответ верный.";
            if (!test.check21)
                ViewBag.Answer21 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer21 = "Ваш ответ верный.";
            if (!test.check22)
                ViewBag.Answer22 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer22 = "Ваш ответ верный.";
            if (!test.check23)
                ViewBag.Answer23 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer23 = "Ваш ответ верный.";
            if (!test.check24)
                ViewBag.Answer24 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer24 = "Ваш ответ верный.";
            if (!test.check25)
                ViewBag.Answer25 = "Ваш ответ неверный. Верный ответ: 3";
            else
                ViewBag.Answer25 = "Ваш ответ верный.";
            if (!test.check26)
                ViewBag.Answer26 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer26 = "Ваш ответ верный.";
            if (!test.check27)
                ViewBag.Answer27 = "Ваш ответ неверный. Верный ответ: 1";
            else
                ViewBag.Answer27 = "Ваш ответ верный.";
            if (!test.check28)
                ViewBag.Answer28 = "Ваш ответ неверный. Верный ответ: 5";
            else
                ViewBag.Answer28 = "Ваш ответ верный.";
            if (!test.check29)
                ViewBag.Answer29 = "Ваш ответ неверный. Верный ответ: 2";
            else
                ViewBag.Answer29 = "Ваш ответ верный.";
            if (!test.check30)
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
            return View();
        }
    }
}