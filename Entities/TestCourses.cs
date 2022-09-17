﻿using SBC.Models.Test.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBC.Entities
{
    public class TestCourses
    {

        public static int RezTest1(Test1 test1)
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

        internal static double RezTest2(Test2 test)
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

        internal static double RezTest3(Test3 test)
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

        internal static double RezTest4(Test4 test)
        {
            int res = 0;

            if (test.question1 == "3")
            {
                test.answer1 = true;
                res++;
            }

            if (test.question2 == "4")
            {
                test.answer2 = true;
                res++;
            }

            if (test.question3 == "4")
            {
                test.answer3 = true;
                res++;
            }

            if (test.question4 == "5")
            {
                test.answer4 = true;
                res++;
            }

            if (test.question5 == "2")
            {
                test.answer5 = true;
                res++;
            }

            if (test.question6 == "4")
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

            if (test.question9 == "2")
            {
                test.answer9 = true;
                res++;
            }

            if (test.question10 == "3")
            {
                test.answer10 = true;
                res++;
            }

            if (test.question11 == "1")
            {
                test.answer11 = true;
                res++;
            }

            if (test.question12 == "5")
            {
                test.answer12 = true;
                res++;
            }

            if (test.question13 == "1")
            {
                test.answer13 = true;
                res++;
            }

            if (test.question14 == "2")
            {
                test.answer14 = true;
                res++;
            }

            if (test.question15 == "5")
            {
                test.answer15 = true;
                res++;
            }

            if (test.question16 == "5")
            {
                test.answer16 = true;
                res++;
            }

            if (test.question17 == "1")
            {
                test.answer17 = true;
                res++;
            }

            if (test.question18 == "5")
            {
                test.answer18 = true;
                res++;
            }

            if (test.question19 == "2")
            {
                test.answer19 = true;
                res++;
            }

            if (test.question20 == "2")
            {
                test.answer20 = true;
                res++;
            }

            if (test.question21 == "2")
            {
                test.answer21 = true;
                res++;
            }

            if (test.question22 == "4")
            {
                test.answer22 = true;
                res++;
            }

            if (test.question23 == "4")
            {
                test.answer23 = true;
                res++;
            }

            if (test.question24 == "1")
            {
                test.answer24 = true;
                res++;
            }

            if (test.question25 == "1")
            {
                test.answer25 = true;
                res++;
            }

            if (test.question26 == "4")
            {
                test.answer26 = true;
                res++;
            }

            if (test.question27 == "3")
            {
                test.answer27 = true;
                res++;
            }

            if (test.question28 == "5")
            {
                test.answer28 = true;
                res++;
            }

            if (test.question29 == "3")
            {
                test.answer29 = true;
                res++;
            }

            if (test.question30 == "4")
            {
                test.answer30 = true;
                res++;
            }

            if (test.question31 == "4")
            {
                test.answer31 = true;
                res++;
            }

            if (test.question32 == "2")
            {
                test.answer32 = true;
                res++;
            }

            if (test.question33 == "3")
            {
                test.answer33 = true;
                res++;
            }

            if (test.question34 == "3")
            {
                test.answer34 = true;
                res++;
            }

            if (test.question35 == "4")
            {
                test.answer35 = true;
                res++;
            }

            if (test.question36 == "1")
            {
                test.answer36 = true;
                res++;
            }

            if (test.question37 == "1")
            {
                test.answer37 = true;
                res++;
            }

            if (test.question38 == "1")
            {
                test.answer38 = true;
                res++;
            }

            if (test.question39 == "5")
            {
                test.answer39 = true;
                res++;
            }

            if (test.question40 == "4")
            {
                test.answer40 = true;
                res++;
            }

            if (test.question41 == null)
            {
                test.question41 = "ответа нет";
            }
            else
            {

                if (test.question41.ToUpper() == "Таксис".ToUpper())
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
                if (test.question42.ToUpper() == "Сократительные вакуоли".ToUpper() || test.question42.ToUpper() == "сократительную вакуоль".ToUpper())
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
                if (test.question43.ToUpper() == "Инцистирование".ToUpper())
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
                if (test.question44.ToUpper() == "Хлорелла и вольвокс".ToUpper() || test.question44.ToUpper() == "вольвокс и хлорелла".ToUpper())
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
                if (test.question45.ToUpper() == "Хлоропласты;".ToUpper())
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
                if (test.question46.ToUpper() == "Ложноножки".ToUpper() || test.question46.ToUpper() == "псевдоподии".ToUpper())
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
                if (test.question47.ToUpper() == "Пелликула".ToUpper())
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
                if (test.question48.ToUpper() == "Эктоплазма".ToUpper())
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
                if (test.question49.ToUpper() == "Эндоплазма".ToUpper())
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
                if (test.question50.ToUpper() == "Фагоцитоз и пиноцитоз".ToUpper() || test.question50.ToUpper() == "пиноцитоз и фагоцитоз".ToUpper() || test.question50.ToUpper() == "пиноцитоз, фагоцитоз".ToUpper() || test.question50.ToUpper() == "Фагоцитоз, пиноцитоз".ToUpper())
                {
                    test.answer50 = true;
                    res++;
                }
            }

            if (test.question51 == null)
            {
                test.question51 = "ответа нет";
            }
            else
            {
                if (test.question51.ToUpper() == "Сократительную вакуоль".ToUpper())
                {
                    test.answer51 = true;
                    res++;
                }
            }

            if (test.question52 == null)
            {
                test.question52 = "ответа нет";
            }
            else
            {
                if (test.question52.ToUpper() == "Цисту".ToUpper())
                {
                    test.answer52 = true;
                    res++;
                }
            }

            if (test.question53 == null)
            {
                test.question53 = "ответа нет";
            }
            else
            {
                if (test.question53.ToUpper() == "7514".ToUpper())
                {
                    test.answer53 = true;
                    res++;
                }
            }

            if (test.question54 == null)
            {
                test.question54 = "ответа нет";
            }
            else
            {
                if (test.question54.ToUpper() == "24196".ToUpper())
                {
                    test.answer54 = true;
                    res++;
                }
            }

            if (test.question55 == null)
            {
                test.question55 = "ответа нет";
            }
            else
            {
                if (test.question55.ToUpper() == "Трихоцисты".ToUpper())
                {
                    test.answer55 = true;
                    res++;
                }
            }

            if (test.question56 == null)
            {
                test.question56 = "ответа нет";
            }
            else
            {
                if (test.question56.ToUpper() == "Клеточный рот".ToUpper() || test.question56.ToUpper() == "цитостом".ToUpper())
                {
                    test.answer56 = true;
                    res++;
                }
            }

            if (test.question57 == null)
            {
                test.question57 = "ответа нет";
            }
            else
            {
                if (test.question57.ToUpper() == "Порошицу".ToUpper())
                {
                    test.answer57 = true;
                    res++;
                }
            }

            if (test.question58 == null)
            {
                test.question58 = "ответа нет";
            }
            else
            {
                if (test.question58.ToUpper() == "35147".ToUpper())
                {
                    test.answer58 = true;
                    res++;
                }
            }

            if (test.question59 == null)
            {
                test.question59 = "ответа нет";
            }
            else
            {
                if (test.question59.ToUpper() == "Автогетеротрофный".ToUpper())
                {
                    test.answer59 = true;
                    res++;
                }
            }

            if (test.question60 == null)
            {
                test.question60 = "ответа нет";
            }
            else
            {
                if (test.question60.ToUpper() == "Стигма".ToUpper())
                {
                    test.answer60 = true;
                    res++;
                }
            }

            if (test.question61 == null)
            {
                test.question61 = "ответа нет";
            }
            else
            {
                if (test.question61.ToUpper() == "Автогетеротрофных".ToUpper())
                {
                    test.answer61 = true;
                    res++;
                }
            }

            if (test.question62 == null)
            {
                test.question62 = "ответа нет";
            }
            else
            {
                if (test.question62.ToUpper() == "Чашевидный".ToUpper())
                {
                    test.answer62 = true;
                    res++;
                }
            }

            if (test.question63 == null)
            {
                test.question63 = "ответа нет";
            }
            else
            {
                if (test.question63.ToUpper() == "Пектина".ToUpper())
                {
                    test.answer63 = true;
                    res++;
                }
            }

            if (test.question64 == null)
            {
                test.question64 = "ответа нет";
            }
            else
            {
                if (test.question64.ToUpper() == "Автотрофных".ToUpper())
                {
                    test.answer64 = true;
                    res++;
                }
            }

            if (test.question65 == null)
            {
                test.question65 = "ответа нет";
            }
            else
            {
                if (test.question65.ToUpper() == "Апланоспорами".ToUpper() || test.question65.ToUpper() == "спорами".ToUpper())
                {
                    test.answer65 = true;
                    res++;
                }
            }

            if (test.question66 == null)
            {
                test.question66 = "ответа нет";
            }
            else
            {
                if (test.question66.ToUpper() == "Автотрофных".ToUpper())
                {
                    test.answer66 = true;
                    res++;
                }
            }

            if (test.question67 == null)
            {
                test.question67 = "ответа нет";
            }
            else
            {
                if (test.question67.ToUpper() == "Репродуктивные".ToUpper())
                {
                    test.answer67 = true;
                    res++;
                }
            }

            if (test.question68 == null)
            {
                test.question68 = "ответа нет";
            }
            else
            {
                if (test.question68.ToUpper() == "Малярийный плазмодий".ToUpper())
                {
                    test.answer68 = true;
                    res++;
                }
            }

            if (test.question69 == null)
            {
                test.question69 = "ответа нет";
            }
            else
            {
                if (test.question69.ToUpper() == "Человек".ToUpper())
                {
                    test.answer69 = true;
                    res++;
                }
            }

            if (test.question70 == null)
            {
                test.question70 = "ответа нет";
            }
            else
            {
                if (test.question70.ToUpper() == "Шизогония".ToUpper())
                {
                    test.answer70 = true;
                    res++;
                }
            }

            if (test.question71 == null)
            {
                test.question71 = "ответа нет";
            }
            else
            {
                if (test.question71.ToUpper() == "Паразитом".ToUpper())
                {
                    test.answer71 = true;
                    res++;
                }
            }

            if (test.question72 == null)
            {
                test.question72 = "ответа нет";
            }
            else
            {
                if (test.question72.ToUpper() == "Спорами".ToUpper())
                {
                    test.answer72 = true;
                    res++;
                }
            }
            return res;
        }

        internal static double RezTest5(Test5 test)
        { 
        }
    }
}