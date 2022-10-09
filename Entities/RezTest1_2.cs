using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SBC.Models.Test.Test1;

namespace SBC.Entities
{
    public class RezTest1_2
    {
        internal static double Rezultat_Test1_2(Test1_2 test)
        {
            int res = 0;

            if (test.question1 == "2")
            {
                test.answer1 = true;
                res++;
            }

            if (test.question2 == "2")
            {
                test.answer2 = true;
                res++;
            }

            if (test.question3 == "3")
            {
                test.answer3 = true;
                res++;
            }

            if (test.question4 == "1")
            {
                test.answer4 = true;
                res++;
            }

            if (test.question5 == "5")
            {
                test.answer5 = true;
                res++;

            }

            if (test.question6 == "3")
            {
                test.answer6 = true;
                res++;
            }

            if (test.question7 == "1")
            {
                test.answer7 = true;
                res++;
            }

            if (test.question8 == "2")
            {
                test.answer8 = true;
                res++;
            }

            if (test.question9 == "2")
            {
                test.answer9 = true;
                res++;
            }

            if (test.question10 == "4")
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

            if (test.question13 == "2")
            {
                test.answer13 = true;
                res++;
            }

            if (test.question14 == "4")
            {
                test.answer14 = true;
                res++;
            }

            if (test.question15 == "3")
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

            if (test.question18 == "4")
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

                if (test.question21.ToUpper() == "вирусы и бактериофаги".ToUpper() || test.question21.ToUpper() == "бактериофаги и вирусы ".ToUpper() || test.question21.ToUpper() == "бактериофаги, вирусы ".ToUpper())
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
                if (test.question22.ToUpper() == "Туорт".ToUpper())
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
                if (test.question23.ToUpper() == "Бейеринк".ToUpper())
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
                if (test.question24.ToUpper() == "Покоящаяся".ToUpper())
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
                if (test.question25.ToUpper() == "размножение".ToUpper())
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
                if (test.question26.ToUpper() == "головку".ToUpper())
                {
                    test.answer26 = true;
                    res++;
                }
            }

            if (test.question27 == null)
            {
                test.question27 = "ответа нет";
            }
            else
            {
                if (test.question27.ToUpper() == "капсид".ToUpper())
                {
                    res++;
                    test.answer27 = true;
                }
            }

            if (test.question28 == null)
            {
                test.question28 = "ответа нет";
            }
            else
            {
                if (test.question28.ToUpper() == "бактериофаги".ToUpper())
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
                if (test.question29.ToUpper() == "вирион".ToUpper())
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
                if (test.question30.ToUpper() == "вирулентным".ToUpper())
                {
                    test.answer30 = true;
                    res++;
                }
            }

            return res;
        }
    }
}