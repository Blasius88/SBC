using SBC.Models.Test.Test1;
using System;
using System.Web.Mvc;
using SBC.Entities;

namespace SBC.Controllers
{
    public class OldTestController : Controller
    {
       
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