using SBC.Models.Test.Test1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SBC.Entities
{
    public class RezTest3_1
    {
        internal static double Rezultat_Test3_1(Test3_1 test)
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

    }
}