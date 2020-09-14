namespace SBC.DAL
{
    public class TestCourses
    {
        public static int Test1(Test1 test1)
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
            if (test1.question11 == "Линней" || test1.question11 == "линней" || test1.question11 == "К.Линней" || test1.question11 == "k.линней" || test1.question11 == "Карл Линней" || test1.question11 == "карл линней")
            {
                res++;
                test1.answer11 = true;
            }
            if (test1.question12 == "Вид" || test1.question12 == "вид")
            {
                test1.answer12 = true;
                res++;
            }
            if (test1.question13 == "Империя" || test1.question13 == "империя")
            {
                test1.answer13 = true;
                res++;
            }
            if (test1.question14 == "Семейства" || test1.question14 == "cемейства")
            {
                test1.answer14 = true;
                res++;
            }
            if (test1.question15 == "Классы" || test1.question15 == "классы")
            {
                test1.answer15 = true;
                res++;
            }
            if (test1.question16 == "Отделы" || test1.question16 == "отделы")
            {
                test1.answer16 = true;
                res++;
            }
            if (test1.question17 == "Царство" || test1.question17 == "царство")
            {
                res++;
                test1.answer17 = true;
            }
            if (test1.question18 == "Отряд" || test1.question18 == "отряд")
            {
                test1.answer18 = true;
                res++;
            }
            if (test1.question19 == "Порядок" || test1.question19 == "порядок")
            {
                test1.answer19 = true;
                res++;
            }
            if (test1.question20 == "Вирусы" || test1.question20 == "вирусы")
            {
                test1.answer20 = true;
                res++;
            }
            if (test1.question21 == "Прокариоты" || test1.question21 == "прокариоты")
            {
                test1.answer21 = true;
                res++;
            }
            if (test1.question22 == "Эукариоты" || test1.question23 == "эукариоты")
            {
                res++;
                test1.answer22 = true;
            }
            if (test1.question23 == "1832596")
            {
                test1.answer23 = true;
                res++;
            }
            if (test1.question24 == "1834576")
            {
                test1.answer24 = true;
                res++;
            }
            return res;
        }

        public static int Test2(Test2 test)
        {
            int sum = 0;
            //Вопрос 1
            if (test.question1 == "2")
            {
                test.check1 = true;
                sum++;
            }
            //вопрос 2
            if (test.question2 == "2")
            {
                test.check2 = true;
                sum++;
            }
            //Вопрос3 
            if (test.question3 == "3")
            {
                test.check3 = true;
                sum++;
            }
            //Вопрос 4
            if (test.question4 == "1")
            {
                test.check4 = true;
                sum++;
            }
            //Вопрос 5
            if (test.question5 == "5")
            {
                test.check5 = true;
                sum++;
            }
            //вопрос 6
            if (test.question6 == "3")
            {
                test.check6 = true;
                sum++;
            }
            //Вопрос 7
            if (test.question7 == "1")
            {
                test.check7 = true;
                sum++;
            }
            //Вопрос 8
            if (test.question8 == "2")
            {
                test.check8 = true;
                sum++;
            }
            //Вопрос 9
            if (test.question9 == "2")
            {
                test.check9 = true;
                sum++;
            }
            //Вопрос10
            if (test.question10 == "4")
            {
                test.check10 = true;
                sum++;
            }
            //Вопрос11
            if (test.question11 == "5")
            {
                test.check11 = true;
                sum++;
            }
            //Вопрос12
            if (test.question12 == "2")
            {
                test.check12 = true;
                sum++;
            }
            //Вопрос13
            if (test.question13 == "2")
            {
                test.check13 = true;
                sum++;
            }
            //Вопрос14
            if (test.question14 == "4")
            {
                test.check14 = true;
                sum++;
            }
            //Вопрос15
            if (test.question15 == "3")
            {
                test.check15 = true;
                sum++;
            }
            //Вопрос16
            if (test.question16 == "3")
            {
                test.check16 = true;
                sum++;
            }
            //Вопрос17
            if (test.question17 == "2")
            {
                test.check17 = true;
                sum++;
            }
            //Вопрос18
            if (test.question18 == "4")
            {
                test.check18 = true;
                sum++;
            }
            //Вопрос19
            if (test.question19 == "5")
            {
                test.check19 = true;
                sum++;
            }
            //Вопрос20
            if (test.question20 == "1")
            {
                test.check20 = true;
                sum++;
            }
            //Вопрос Б1
            if (test.question21 == "вирусы и бактериофаги" || test.question21 == "Вирусы и Бактериофаги" || test.question21 == "вирусы бактериофаги" || test.question21 == "вирусы, бактериофаги" || test.question21 == "Вирусы, Бактериофаги")
            {
                test.check21 = true;
                sum++;
            }
            //Вопрос Б2
            if (test.question22 == "Туорт" || test.question22 == "туорт")
            {
                test.check22 = true;
                sum++;
            }
            //Вопрос Б3
            if (test.question23 == "Бейеринк" || test.question23 == "бейеринк")
            {
                test.check23 = true;
                sum++;
            }
            //Вопрос Б4
            if (test.question24 == "Покоящаяся" || test.question24 == "покоящаяся")
            {
                test.check24 = true;
                sum++;
            }
            //Вопрос Б5
            if (test.question25 == "размножение" || test.question25 == "Размножение")
            {
                test.check25 = true;
                sum++;
            }
            //Вопрос Б6
            if (test.question26 == "головку" || test.question26 == "головка" || test.question26 == "Головку" || test.question26 == "Головка")
            {
                test.check26 = true;
                sum++;
            }
            //Вопрос Б7
            if (test.question27 == "капсид" || test.question27 == "Капсид")
            {
                test.check27 = true;
                sum++;
            }
            //Вопрос Б8
            if (test.question28 == "бактериофаги" || test.question28 == "Бактериофаги" || test.question28 == "бактериофаг" || test.question28 == "Бактериофаг" || test.question28 == "бактериофага" || test.question28 == "Бактериофага")
            {
                test.check28 = true;
                sum++;
            }
            //Вопрос Б9
            if (test.question29 == "вирион" || test.question29 == "Вирион" || test.question29 == "вирионы" || test.question29 == "Вирионы")
            {
                test.check29 = true;
                sum++;
            }
            //Вопрос Б10
            if (test.question30 == "вирулентным" || test.question30 == "Вирулентным")
            {
                test.check30 = true;
                sum++;
            }
            return sum;
        }

        public static int Test3(Test3 test)
        {
            int sum = 0;
            if (test.question1 == "1")
            {
                test.check1 = true;
                sum++;
            }
            //вопрос 2
            if (test.question2 == "2")
            {
                test.check2 = true;
                sum++;
            }
            //Вопрос3 
            if (test.question3 == "5")
            {
                test.check3 = true;
                sum++;
            }
            //Вопрос 4
            if (test.question4 == "1")
            {
                test.check4 = true;
                sum++;
            }
            //Вопрос 5
            if (test.question5 == "2")
            {
                test.check5 = true;
                sum++;
            }
            //вопрос 6
            if (test.question6 == "5")
            {
                test.check6 = true;
                sum++;
            }
            //Вопрос 7
            if (test.question7 == "2")
            {
                test.check7 = true;
                sum++;
            }
            //Вопрос 8
            if (test.question8 == "3")
            {
                test.check8 = true;
                sum++;
            }
            //Вопрос 9
            if (test.question9 == "4")
            {
                test.check9 = true;
                sum++;
            }
            //Вопрос10
            if (test.question10 == "2")
            {
                test.check10 = true;
                sum++;
            }
            //Вопрос11
            if (test.question11 == "5")
            {
                test.check11 = true;
                sum++;
            }
            //Вопрос12
            if (test.question12 == "1")
            {
                test.check12 = true;
                sum++;
            }
            //Вопрос13
            if (test.question13 == "3")
            {
                test.check13 = true;
                sum++;
            }
            //Вопрос14
            if (test.question14 == "2")
            {
                test.check14 = true;
                sum++;
            }
            //Вопрос15
            if (test.question15 == "4")
            {
                test.check15 = true;
                sum++;
            }
            //Вопрос16
            if (test.question16 == "1")
            {
                test.check16 = true;
                sum++;
            }
            //Вопрос17
            if (test.question17 == "3")
            {
                test.check17 = true;
                sum++;
            }
            //Вопрос18
            if (test.question18 == "3")
            {
                test.check18 = true;
                sum++;
            }
            //Вопрос19
            if (test.question19 == "5")
            {
                test.check19 = true;
                sum++;
            }
            //Вопрос20
            if (test.question20 == "2")
            {
                test.check20 = true;
                sum++;
            }
            //Вопрос21
            if (test.question21 == "1")
            {
                test.check21 = true;
                sum++;
            }
            //Вопрос22
            if (test.question22 == "3")
            {
                test.check22 = true;
                sum++;
            }
            //Вопрос23
            if (test.question23 == "3")
            {
                test.check23 = true;
                sum++;
            }
            //Вопрос24
            if (test.question24 == "2")
            {
                test.check24 = true;
                sum++;
            }
            //Вопрос25
            if (test.question25 == "3")
            {
                test.check25 = true;
                sum++;
            }
            //Вопрос26
            if (test.question26 == "5")
            {
                test.check26 = true;
                sum++;
            }
            //Вопрос27
            if (test.question27 == "1")
            {
                test.check27 = true;
                sum++;
            }
            //Вопрос28
            if (test.question28 == "5")
            {
                test.check28 = true;
                sum++;
            }
            //Вопрос29
            if (test.question29 == "2")
            {
                test.check29 = true;
                sum++;
            }
            //Вопрос30
            if (test.question30 == "4")
            {
                test.check30 = true;
                sum++;
            }
            //Вопрос31
            if (test.question31 == "Цианобактерии" || test.question31 == "цианобактерии")
            {
                test.check31 = true;
                sum++;
            }
            //Вопрос32
            if (test.question32 == "Муреин" || test.question32 == "муреин")
            {
                test.check32 = true;
                sum++;
            }
            //Вопрос33
            if (test.question33 == "Стрептококки" || test.question33 == "стрептококки")
            {
                test.check33 = true;
                sum++;
            }
            //Вопрос34
            if (test.question34 == "Нуклеоид" || test.question34 == "нуклеоид")
            {
                test.check34 = true;
                sum++;
            }
            //Вопрос35
            if (test.question35 == "ДНК")
            {
                test.check35 = true;
                sum++;
            }
            //Вопрос36
            if (test.question36 == "Мезосомы" || test.question36 == "мезосомы")
            {
                test.check36 = true;
                sum++;
            }
            //Вопрос37
            if (test.question37 == "Бактериохлорофилл" || test.question37 == "бактериохлорофилл")
            {
                test.check37 = true;
                sum++;
            }
            //Вопрос38
            if (test.question38 == "Автотрофные и Гетеротрофные" || test.question38 == "автотрофные и гетеротрофные" || test.question38 == "автотрофные, гетеротрофные" || test.question38 == "Автотрофные, Гетеротрофные" || test.question38 == "автотрофные , гетеротрофные" || test.question38 == "Автотрофные , Гетеротрофные")
            {
                test.check38 = true;
                sum++;
            }
            //Вопрос39
            if (test.question39 == "Хемотрофы" || test.question39 == "хемотрофы")
            {
                test.check39 = true;
                sum++;
            }
            //Вопрос40
            if (test.question40 == "Азотобактерии и Цианобактерии" || test.question30 == "азотобактерии и цианобактерии")
            {
                test.check40 = true;
                sum++;
            }
            //Вопрос41
            if (test.question41 == "Нитрифицирующие" || test.question41 == "нитрифицирующие")
            {
                test.check41 = true;
                sum++;
            }
            //Вопрос42
            if (test.question42 == "Сапротрофы" || test.question42 == "сапротрофы")
            {
                test.check42 = true;
                sum++;
            }
            //Вопрос43
            if (test.question43 == "Молочнокислые" || test.question44 == "молочнокислые")
            {
                test.check43 = true;
                sum++;
            }
            //Вопрос44
            if (test.question44 == "Болезнетворные" || test.question44 == "Паразитические" || test.question44 == "болезнетворные" || test.question44 == "паразитические" || test.question44 == "Болезнетворные/Паразитические" || test.question44 == "болезнетворные/паразитические" || test.question44 == "Болезнетворные/паразитические" || test.question44 == "болезнетворные/Паразитические" || test.question44 == "паразитические/болезнетворные" || test.question44 == "Паразитические/болезнетворные" || test.question44 == "Паразитические/Болезнетворные" || test.question44 == "паразитические/Болезнетворные")
            {
                test.check44 = true;
                sum++;
            }
            //Вопрос45
            if (test.question45 == "Факультативными анаэробами" || test.question45 == "факультативными Анаэробами" || test.question45 == "факультативными анаэробам")
            {
                test.check45 = true;
                sum++;
            }
            //Вопрос46
            if (test.question46 == "Коньюгация" || test.question46 == "коньюгация")
            {
                test.check46 = true;
                sum++;
            }
            //Вопрос47
            if (test.question47 == "Споры" || test.question47 == "споры")
            {
                test.check47 = true;
                sum++;
            }
            //Вопрос48
            if (test.question48 == "Стерилизация" || test.question48 == "стерилизация")
            {
                test.check48 = true;
                sum++;
            }
            //Вопрос49
            if (test.question49 == "Паразиты" || test.question49 == "паразиты")
            {
                test.check49 = true;
                sum++;
            }
            //Вопрос50
            if (test.question50 == "Сапротрофные" || test.question50 == "сапротрофные")
            {
                test.check50 = true;
                sum++;
            }
            return sum;

        }
    }
}
