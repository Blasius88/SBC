using SBC.Models.Test.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBC.Entities
{
    public class RezTest5
    {
        internal static double Rezultat_Test5(Test5 test)
        {
            int res = 0;
            if (test.question1 == "4")
            {
                test.answer1 = true;
                res++;
            }

            if (test.question2 == "1")
            {
                test.answer2 = true;
                res++;
            }

            if (test.question3 == "2")
            {
                test.answer3 = true;
                res++;
            }

            if (test.question4 == "4")
            {
                test.answer4 = true;
                res++;
            }

            if (test.question5 == "4")
            {
                test.answer5 = true;
                res++;
            }

            if (test.question6 == "2")
            {
                test.answer6 = true;
                res++;
            }

            if (test.question7 == "2")
            {
                test.answer7 = true;
                res++;
            }

            if (test.question8 == "1")
            {
                test.answer8 = true;
                res++;
            }

            if (test.question9 == "2")
            {
                test.answer9 = true;
                res++;
            }

            if (test.question10 == "1")
            {
                test.answer10 = true;
                res++;
            }

            if (test.question11 == "5")
            {
                test.answer11 = true;
                res++;
            }

            if (test.question12 == "2")
            {
                test.answer12 = true;
                res++;
            }

            if (test.question13 == "1")
            {
                test.answer13 = true;
                res++;
            }

            if (test.question14 == "4")
            {
                test.answer14 = true;
                res++;
            }

            if (test.question15 == "1")
            {
                test.answer15 = true;
                res++;
            }

            if (test.question16 == "5")
            {
                test.answer16 = true;
                res++;
            }

            if (test.question17 == "4")
            {
                test.answer17 = true;
                res++;
            }

            if (test.question18 == "2")
            {
                test.answer18 = true;
                res++;
            }

            if (test.question19 == "2")
            {
                test.answer19 = true;
                res++;
            }

            if (test.question20 == "5")
            {
                test.answer20 = true;
                res++;
            }
            if (test.question21 == "3")
            {
                test.answer21 = true;
                res++;
            }
            if (test.question22 == "3")
            {
                test.answer22 = true;
                res++;
            }
            if (test.question23 == "5")
            {
                test.answer23 = true;
                res++;
            }
            if (test.question24 == "2")
            {
                test.answer24 = true;
                res++;
            }
            if (test.question25 == "2")
            {
                test.answer25 = true;
                res++;
            }
            if (test.question26 == "4")
            {
                test.answer26 = true;
                res++;
            }
            if (test.question27 == "5")
            {
                test.answer27 = true;
                res++;
            }
            if (test.question28 == "2")
            {
                test.answer28 = true;
                res++;
            }
            if (test.question29 == "5")
            {
                test.answer29 = true;
                res++;
            }
            if (test.question30 == "2")
            {
                test.answer30 = true;
                res++;
            }
            if (test.question31 == null)
            {
                test.question31 = "ответа нет";
            }
            else
            {

                if (test.question31.ToUpper() == "Экология".ToUpper())
                {
                    res++;
                    test.answer31 = true;
                }
            }
            if (test.question32 == null)
            {
                test.question32 = "ответа нет";
            }
            else
            {

                if (test.question32.ToUpper() == "А1Б1В2Г2Д3".ToUpper())
                {
                    res++;
                    test.answer32 = true;
                }
            }
            if (test.question33 == null)
            {
                test.question33 = "ответа нет";
            }
            else
            {

                if (test.question33.ToUpper() == "А2Б1В1Г3Д2".ToUpper())
                {
                    res++;
                    test.answer33 = true;
                }
            }
            if (test.question34 == null)
            {
                test.question34 = "ответа нет";
            }
            else
            {

                if (test.question34.ToUpper() == "А3Б1В2Г4Д1".ToUpper())
                {
                    res++;
                    test.answer34 = true;
                }
            }
            if (test.question35 == null)
            {
                test.question35 = "ответа нет";
            }
            else
            {

                if (test.question35.ToUpper() == "Образовательные".ToUpper())
                {
                    res++;
                    test.answer35 = true;
                }
            }
            if (test.question36 == null)
            {
                test.question36 = "ответа нет";
            }
            else
            {

                if (test.question36.ToUpper() == "Камбий".ToUpper())
                {
                    res++;
                    test.answer36 = true;
                }
            }
            if (test.question37 == null)
            {
                test.question37 = "ответа нет";
            }
            else
            {

                if (test.question37.ToUpper() == "Покровные".ToUpper())
                {
                    res++;
                    test.answer37 = true;
                }
            }
            if (test.question38 == null)
            {
                test.question38 = "ответа нет";
            }
            else
            {

                if (test.question38.ToUpper() == "Эпидермис".ToUpper() || test.question38.ToUpper () == "эпидерма".ToUpper())
                {
                    res++;
                    test.answer38 = true;
                }
            }
            if (test.question39 == null)
            {
                test.question39 = "ответа нет";
            }
            else
            {

                if (test.question39.ToUpper() == "Пробка".ToUpper() || test.question39.ToUpper () == "перидерма".ToUpper ())
                {
                    res++;
                    test.answer39 = true;
                }
            }
            if (test.question40 == null)
            {
                test.question40 = "ответа нет";
            }
            else
            {

                if (test.question40.ToUpper() == "Корка".ToUpper() || test.question40.ToUpper() == "ритидом".ToUpper())
                {
                    res++;
                    test.answer40 = true;
                }
            }
            if (test.question41 == null)
            {
                test.question41 = "ответа нет";
            }
            else
            {

                if (test.question41.ToUpper() == "Чечевички".ToUpper())
                {
                    res++;
                    test.answer41 = true;
                }
            }
            if (test.question42 == null)
            {
                test.question42 = "ответа нет";
            }
            else
            {

                if (test.question42.ToUpper() == "Трещинки".ToUpper())
                {
                    res++;
                    test.answer42 = true;
                }
            }
            if (test.question43 == null)
            {
                test.question43 = "ответа нет";
            }
            else
            {

                if (test.question43.ToUpper() == "Пробка".ToUpper())
                {
                    res++;
                    test.answer43 = true;
                }
            }
            if (test.question44 == null)
            {
                test.question44 = "ответа нет";
            }
            else
            {

                if (test.question44.ToUpper() == "Пробка".ToUpper() || test.question44.ToUpper() == "феллема".ToUpper())
                {
                    res++;
                    test.answer44 = true;
                }
            }
            if (test.question45 == null)
            {
                test.question45 = "ответа нет";
            }
            else
            {

                if (test.question45.ToUpper() == "Феллодерма".ToUpper())
                {
                    res++;
                    test.answer45 = true;
                }
            }
            if (test.question46 == null)
            {
                test.question46 = "ответа нет";
            }
            else
            {

                if (test.question46.ToUpper() == "Ассимиляционная".ToUpper())
                {
                    res++;
                    test.answer46 = true;
                }
            }
            if (test.question47 == null)
            {
                test.question47 = "ответа нет";
            }
            else
            {

                if (test.question47.ToUpper() == "Водоносная".ToUpper())
                {
                    res++;
                    test.answer47 = true;
                }
            }
            if (test.question48 == null)
            {
                test.question48 = "ответа нет";
            }
            else
            {

                if (test.question48.ToUpper() == "Запасающая".ToUpper())
                {
                    res++;
                    test.answer48 = true;
                }
            }
            if (test.question49 == null)
            {
                test.question49 = "ответа нет";
            }
            else
            {

                if (test.question49.ToUpper() == "Колленхима".ToUpper())
                {
                    res++;
                    test.answer49 = true;
                }
            }
            if (test.question50 == null)
            {
                test.question50 = "ответа нет";
            }
            else
            {

                if (test.question50.ToUpper() == "Склеренхима".ToUpper())
                {
                    res++;
                    test.answer50 = true;
                }
            }
            if (test.question51 == null)
            {
                test.question51 = "ответа нет";
            }
            else
            {

                if (test.question51.ToUpper() == "Проводящие;".ToUpper())
                {
                    res++;
                    test.answer51 = true;
                }
            }
            if (test.question52 == null)
            {
                test.question52 = "ответа нет";
            }
            else
            {

                if (test.question52.ToUpper() == "Ситовидные трубки".ToUpper())
                {
                    res++;
                    test.answer52 = true;
                }
            }
            if (test.question53 == null)
            {
                test.question53 = "ответа нет";
            }
            else
            {

                if (test.question53.ToUpper() == "Ксилема".ToUpper())
                {
                    res++;
                    test.answer53 = true;
                }
            }
            if (test.question54 == null)
            {
                test.question54 = "ответа нет";
            }
            else
            {

                if (test.question54.ToUpper() == "Трахеи".ToUpper() || test.question54.ToUpper() == "сосуды".ToUpper())
                {
                    res++;
                    test.answer54 = true;
                }
            }
            if (test.question55 == null)
            {
                test.question55 = "ответа нет";
            }
            else
            {

                if (test.question55.ToUpper() == "А1Б1В2Г1Д3".ToUpper())
                {
                    res++;
                    test.answer55 = true;
                }
            }

            if (test.question56 == null)
            {
                test.question56 = "ответа нет";
            }
            else
            {

                if (test.question56.ToUpper() == "Тропизмы".ToUpper())
                {
                    res++;
                    test.answer56 = true;
                }
            }
            if (test.question57 == null)
            {
                test.question57 = "ответа нет";
            }
            else
            {

                if (test.question57.ToUpper() == "Фототропизм".ToUpper() || test.question57.ToUpper() == "гелиотропизм".ToUpper())
                {
                    res++;
                    test.answer57 = true;
                }
            }
            if (test.question58 == null)
            {
                test.question58 = "ответа нет";
            }
            else
            {

                if (test.question58.ToUpper() == "Настия".ToUpper())
                {
                    res++;
                    test.answer58 = true;
                }
            }

            return res;
        }
    }
}