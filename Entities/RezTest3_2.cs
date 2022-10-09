using SBC.Models.Test.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBC.Entities
{
    public class RezTest3_2
    {
        internal static double Rezultat_Test3_2(Test3_2 test)
        {
            int res = 0;

            if (test.question1 == "2")
            {
                test.answer1 = true;
                res++;
            }

            if (test.question2 == "4")
            {
                test.answer2 = true;
                res++;
            }

            if (test.question3 == "2")
            {
                test.answer3 = true;
                res++;
            }

            if (test.question4 == "3")
            {
                test.answer4 = true;
                res++;
            }

            if (test.question5 == "2")
            {
                test.answer5 = true;
                res++;
            }

            if (test.question6 == "1")
            {
                test.answer6 = true;
                res++;
            }

            if (test.question7 == "1")
            {
                test.answer7 = true;
                res++;
            }

            if (test.question8 == "1")
            {
                test.answer8 = true;
                res++;
            }

            if (test.question9 == "1")
            {
                test.answer9 = true;
                res++;
            }

            if (test.question10 == "2")
            {
                test.answer10 = true;
                res++;
            }

            if (test.question11 == "3")
            {
                test.answer11 = true;
                res++;
            }

            if (test.question12 == "1")
            {
                test.answer12 = true;
                res++;
            }

            if (test.question13 == "4")
            {
                test.answer13 = true;
                res++;
            }

            if (test.question14 == "4")
            {
                test.answer14 = true;
                res++;
            }

            if (test.question15 == "5")
            {
                test.answer15 = true;
                res++;
            }

            if (test.question16 == "3")
            {
                test.answer16 = true;
                res++;
            }

            if (test.question17 == "2")
            {
                test.answer17 = true;
                res++;
            }

            if (test.question18 == "3")
            {
                test.answer18 = true;
                res++;
            }

            if (test.question19 == "5")
            {
                test.answer19 = true;
                res++;
            }

            if (test.question20 == "1")
            {
                test.answer20 = true;
                res++;
            }

            if (test.question21 == null)
            {
                test.question21 = "ответа нет";
            }
            else
            {

                if (test.question21.ToUpper() == "Талломом".ToUpper() || test.question21.ToUpper() == "слоевищем".ToUpper())
                {
                    res++;
                    test.answer21 = true;
                }
            }

            if (test.question22 == null)
            {
                test.question22 = "ответа нет";
            }
            else
            {
                if (test.question22.ToUpper() == "Хлоропласты".ToUpper())
                {
                    test.answer22 = true;
                    res++;
                }
            }

            if (test.question23 == null)
            {
                test.question23 = "ответа нет";
            }
            else
            {
                if (test.question23.ToUpper() == "Зеленые водоросли".ToUpper())
                {
                    test.answer23 = true;
                    res++;
                }
            }

            if (test.question24 == null)
            {
                test.question24 = "ответа нет";
            }
            else
            {
                if (test.question24.ToUpper() == "Ульва;".ToUpper())
                {
                    test.answer24 = true;
                    res++;
                }
            }

            if (test.question25 == null)
            {
                test.question25 = "ответа нет";
            }
            else
            {
                if (test.question25.ToUpper() == "Бурые водоросли".ToUpper())
                {
                    test.answer25 = true;
                    res++;
                }
            }

            if (test.question26 == null)
            {
                test.question26 = "ответа нет";
            }
            else
            {
                if (test.question26.ToUpper() == "Красные водоросли".ToUpper())
                {
                    res++;
                    test.answer26 = true;
                }
            }

            if (test.question27 == null)
            {
                test.question27 = "ответа нет";
            }
            else
            {
                if (test.question27.ToUpper() == "Зооспоры".ToUpper())
                {
                    test.answer27 = true;
                    res++;
                }
            }

            if (test.question28 == null)
            {
                test.question28 = "ответа нет";
            }
            else
            {
                if (test.question28.ToUpper() == "Спирогира".ToUpper())
                {
                    test.answer28 = true;
                    res++;
                }
            }
            if (test.question29 == null)
            {
                test.question29 = "ответа нет";
            }
            else
            {
                if (test.question29.ToUpper() == "Незамкнутого кольца".ToUpper() || test.question29.ToUpper() == "пояска".ToUpper() || test.question29.ToUpper() == "цилиндра".ToUpper())
                {
                    test.answer29 = true;
                    res++;
                }
            }
            if (test.question30 == null)
            {
                test.question30 = "ответа нет";
            }
            else
            {
                if (test.question30.ToUpper() == "Ламинарию и порфиру".ToUpper() || test.question30.ToUpper() == "порфиру и ламинарию".ToUpper())
                {
                    test.answer30 = true;
                    res++;
                }
            }
            return res;
        }
    }
}