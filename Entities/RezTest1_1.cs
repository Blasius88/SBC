using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SBC.Models.Test.Test1;

namespace SBC.Entities
{
    public class RezTest1_1
    {
        public static int Rezultat_Test1_1(Test1_1 test1)
        {
            int res = 0;

            if (test1.question1 == "1")
            {
                test1.answer1 = true;
                res++;
            }

            if (test1.question2 == "3")
            {
                test1.answer2 = true;
                res++;
            }

            if (test1.question3 == "3")
            {
                test1.answer3 = true;
                res++;
            }

            if (test1.question4 == "3")
            {
                test1.answer4 = true;
                res++;
            }

            if (test1.question5 == "2")
            {
                test1.answer5 = true;
                res++;

            }

            if (test1.question6 == "1")
            {
                test1.answer6 = true;
                res++;
            }

            if (test1.question7 == "3")
            {
                test1.answer7 = true;
                res++;
            }

            if (test1.question8 == "1")
            {
                test1.answer8 = true;
                res++;
            }

            if (test1.question9 == "4")
            {
                test1.answer9 = true;
                res++;
            }

            if (test1.question10 == "4")
            {
                test1.answer10 = true;
                res++;
            }

            if (test1.question11 == null)
            {
                test1.question11 = "ответа нет";
            }
            else
            {

                if (test1.question11.ToUpper() == "Линней".ToUpper() || test1.question11.ToUpper() == "К.Линней".ToUpper() || test1.question11.ToUpper() == "Карл Линней".ToUpper())
                {
                    res++;
                    test1.answer11 = true;
                }
            }

            if (test1.question12 == null)
            {
                test1.question12 = "ответа нет";
            }
            else
            {
                if (test1.question12.ToUpper() == "Вид".ToUpper())
                {
                    test1.answer12 = true;
                    res++;
                }
            }

            if (test1.question13 == null)
            {
                test1.question13 = "ответа нет";
            }
            else
            {
                if (test1.question13.ToUpper() == "Империя".ToUpper())
                {
                    test1.answer13 = true;
                    res++;
                }
            }

            if (test1.question14 == null)
            {
                test1.question14 = "ответа нет";
            }
            else
            {
                if (test1.question14.ToUpper() == "Семейства".ToUpper())
                {
                    test1.answer14 = true;
                    res++;
                }

            }

            if (test1.question15 == null)
            {
                test1.question15 = "ответа нет";
            }
            else
            {
                if (test1.question15.ToUpper() == "Классы".ToUpper())
                {
                    test1.answer15 = true;
                    res++;
                }
            }

            if (test1.question16 == null)
            {
                test1.question16 = "ответа нет";
            }
            else
            {
                if (test1.question16.ToUpper() == "Отделы".ToUpper())
                {
                    test1.answer16 = true;
                    res++;
                }
            }

            if (test1.question17 == null)
            {
                test1.question17 = "ответа нет";
            }
            else
            {
                if (test1.question17.ToUpper() == "Царство".ToUpper())
                {
                    res++;
                    test1.answer17 = true;
                }
            }

            if (test1.question18 == null)
            {
                test1.question18 = "ответа нет";
            }
            else
            {
                if (test1.question18.ToUpper() == "Отряд".ToUpper())
                {
                    test1.answer18 = true;
                    res++;
                }
            }

            if (test1.question19 == null)
            {
                test1.question19 = "ответа нет";
            }
            else
            {
                if (test1.question19.ToUpper() == "Порядок".ToUpper())
                {
                    test1.answer19 = true;
                    res++;
                }
            }

            if (test1.question20 == null)
            {
                test1.question20 = "ответа нет";
            }
            else
            {
                if (test1.question20.ToUpper() == "Вирусы".ToUpper())
                {
                    test1.answer20 = true;
                    res++;
                }
            }

            if (test1.question21 == null)
            {
                test1.question21 = "ответа нет";
            }
            else
            {
                if (test1.question21.ToUpper() == "Прокариоты".ToUpper())
                {
                    test1.answer21 = true;
                    res++;
                }
            }

            if (test1.question22 == null)
            {
                test1.question22 = "ответа нет";
            }
            else
            {
                if (test1.question22.ToUpper() == "Эукариоты".ToUpper())
                {
                    res++;
                    test1.answer22 = true;
                }

            }

            if (test1.question23 == null)
            {
                test1.question23 = "ответа нет";
            }
            else
            {
                if (test1.question23 == "1832596")
                {
                    test1.answer23 = true;
                    res++;
                }
            }

            if (test1.question24 == null)
            {
                test1.question24 = "ответа нет";
            }
            else
            {
                if (test1.question24 == "1834576")
                {
                    test1.answer24 = true;
                    res++;
                }
            }

            return res;
        }

    }
}