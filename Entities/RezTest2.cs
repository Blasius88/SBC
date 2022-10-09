using SBC.Models.Test.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBC.Entities
{
    public class RezTest2
    {

        internal static double Rezultat_Test2(Test2 test)
        {
            int res = 0;

            if (test.question1 == "1")
            {
                test.answer1 = true;
                res++;
            }

            if (test.question2 == "2")
            {
                test.answer2 = true;
                res++;
            }

            if (test.question3 == "5")
            {
                test.answer3 = true;
                res++;
            }

            if (test.question4 == "1")
            {
                test.answer4 = true;
                res++;
            }

            if (test.question5 == "2")
            {
                test.answer5 = true;
                res++;
            }

            if (test.question6 == "5")
            {
                test.answer6 = true;
                res++;
            }

            if (test.question7 == "2")
            {
                test.answer7 = true;
                res++;
            }

            if (test.question8 == "3")
            {
                test.answer8 = true;
                res++;
            }

            if (test.question9 == "4")
            {
                test.answer9 = true;
                res++;
            }

            if (test.question10 == "2")
            {
                test.answer10 = true;
                res++;
            }

            if (test.question11 == "5")
            {
                test.answer11 = true;
                res++;
            }

            if (test.question12 == "1")
            {
                test.answer12 = true;
                res++;
            }

            if (test.question13 == "3")
            {
                test.answer13 = true;
                res++;
            }

            if (test.question14 == "2")
            {
                test.answer14 = true;
                res++;
            }

            if (test.question15 == "4")
            {
                test.answer15 = true;
                res++;
            }

            if (test.question16 == "1")
            {
                test.answer16 = true;
                res++;
            }

            if (test.question17 == "3")
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

            if (test.question20 == "2")
            {
                test.answer20 = true;
                res++;
            }

            if (test.question21 == "1")
            {
                test.answer21 = true;
                res++;
            }

            if (test.question22 == "3")
            {
                test.answer22 = true;
                res++;
            }

            if (test.question23 == "3")
            {
                test.answer23 = true;
                res++;
            }

            if (test.question24 == "2")
            {
                test.answer24 = true;
                res++;
            }

            if (test.question25 == "3")
            {
                test.answer25 = true;
                res++;
            }

            if (test.question26 == "5")
            {
                test.answer26 = true;
                res++;
            }

            if (test.question27 == "1")
            {
                test.answer27 = true;
                res++;
            }

            if (test.question28 == "5")
            {
                test.answer28 = true;
                res++;
            }

            if (test.question29 == "2")
            {
                test.answer29 = true;
                res++;
            }

            if (test.question30 == "4")
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

                if (test.question31.ToUpper() == "Цианобактерии".ToUpper())
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
                if (test.question32.ToUpper() == "Муреин".ToUpper())
                {
                    test.answer32 = true;
                    res++;
                }
            }

            if (test.question33 == null)
            {
                test.question33 = "ответа нет";
            }
            else
            {
                if (test.question33.ToUpper() == "Стрептококки".ToUpper())
                {
                    test.answer33 = true;
                    res++;
                }
            }

            if (test.question34 == null)
            {
                test.question34 = "ответа нет";
            }
            else
            {
                if (test.question34.ToUpper() == "Нуклеоид".ToUpper())
                {
                    test.answer34 = true;
                    res++;
                }

            }

            if (test.question35 == null)
            {
                test.question35 = "ответа нет";
            }
            else
            {
                if (test.question35.ToUpper() == "ДНК".ToUpper())
                {
                    test.answer35 = true;
                    res++;
                }
            }

            if (test.question36 == null)
            {
                test.question36 = "ответа нет";
            }
            else
            {
                if (test.question36.ToUpper() == "Мезосомы".ToUpper())
                {
                    test.answer36 = true;
                    res++;
                }
            }

            if (test.question37 == null)
            {
                test.question37 = "ответа нет";
            }
            else
            {
                if (test.question37.ToUpper() == "Бактериохлорофилл".ToUpper())
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
                if (test.question38.ToUpper() == "Автотрофные и гетеротрофные".ToUpper() || test.question38.ToUpper() == "гетеротрофные и Автотрофные".ToUpper() || test.question38.ToUpper() == "Автотрофные, гетеротрофные".ToUpper() || test.question38.ToUpper() == "гетеротрофные, Автотрофные".ToUpper())
                {
                    test.answer38 = true;
                    res++;
                }
            }

            if (test.question39 == null)
            {
                test.question39 = "ответа нет";
            }
            else
            {
                if (test.question39.ToUpper() == "Хемотрофы".ToUpper())
                {
                    test.answer39 = true;
                    res++;
                }
            }

            if (test.question40 == null)
            {
                test.question40 = "ответа нет";
            }
            else
            {
                if (test.question40.ToUpper() == "Азотобактерии и цианобактерии".ToUpper() || test.question40.ToUpper() == "Азотобактерии, цианобактерии".ToUpper() || test.question40.ToUpper() == "цианобактерии и Азотобактерии".ToUpper() || test.question40.ToUpper() == "цианобактерии, Азотобактерии".ToUpper())
                {
                    test.answer40 = true;
                    res++;
                }
            }

            if (test.question41 == null)
            {
                test.question41 = "ответа нет";
            }
            else
            {
                if (test.question41.ToUpper() == "Нитрифицирующие".ToUpper())
                {
                    test.answer41 = true;
                    res++;
                }
            }

            if (test.question42 == null)
            {
                test.question42 = "ответа нет";
            }
            else
            {
                if (test.question42.ToUpper() == "Сапротрофы".ToUpper())
                {
                    test.answer42 = true;
                    res++;
                }
            }

            if (test.question43 == null)
            {
                test.question43 = "ответа нет";
            }
            else
            {
                if (test.question43.ToUpper() == "Молочнокислые".ToUpper())
                {
                    test.answer43 = true;
                    res++;
                }
            }

            if (test.question44 == null)
            {
                test.question44 = "ответа нет";
            }
            else
            {
                if (test.question44.ToUpper() == "Болезнетворные".ToUpper() || test.question44.ToUpper() == "паразитические".ToUpper())
                {
                    test.answer44 = true;
                    res++;
                }
            }

            if (test.question45 == null)
            {
                test.question45 = "ответа нет";
            }
            else
            {
                if (test.question45.ToUpper() == "Факультативными анаэробами".ToUpper())
                {
                    test.answer45 = true;
                    res++;
                }
            }

            if (test.question46 == null)
            {
                test.question46 = "ответа нет";
            }
            else
            {
                if (test.question46.ToUpper() == "Коньюгация".ToUpper())
                {
                    test.answer46 = true;
                    res++;
                }
            }

            if (test.question47 == null)
            {
                test.question47 = "ответа нет";
            }
            else
            {
                if (test.question47.ToUpper() == "Споры".ToUpper())
                {
                    test.answer47 = true;
                    res++;
                }
            }

            if (test.question48 == null)
            {
                test.question48 = "ответа нет";
            }
            else
            {
                if (test.question48.ToUpper() == "Стерилизация ".ToUpper())
                {
                    test.answer48 = true;
                    res++;
                }
            }

            if (test.question49 == null)
            {
                test.question49 = "ответа нет";
            }
            else
            {
                if (test.question49.ToUpper() == "Паразиты".ToUpper())
                {
                    test.answer49 = true;
                    res++;
                }
            }

            if (test.question50 == null)
            {
                test.question50 = "ответа нет";
            }
            else
            {
                if (test.question50.ToUpper() == "Сапротрофные".ToUpper())
                {
                    test.answer50 = true;
                    res++;
                }
            }

            return res;
        }

    }
}