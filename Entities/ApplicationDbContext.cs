using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SBC.Error;
using SBC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;


namespace SBC.Entities
{
    public partial class ApplicationDbContext
    {
        public string error;
        public DbSet<CoursesItem> Courses { get; set; }
        public DbSet<TestItem> test { get; set; }
        public DbSet<QuestionItem> questions { get; set; }
        public DbSet<LernenItem> lernens { get; set; }

        public void Populate()
        {
            try
            {
                if (!Roles.Any())
                {
                    // Создаем менеджеры ролей и пользователей
                    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(this));
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this));
                    // Создаем роли "admin" и "user"
                    roleManager.Create(new IdentityRole("admin"));
                    roleManager.Create(new IdentityRole("user"));
                    roleManager.Create(new IdentityRole("teacher"));
                }
                if (!Courses.Any())
                {
                    List<CoursesItem> list = new List<CoursesItem>
                {
                    new CoursesItem
                    {
                        id  =1,
                        NameCourses = "Биология",
                        Description = "This is courses biolodia"
                    },
                     new CoursesItem
                    {
                        id  =2,
                        NameCourses = "Химия",
                        Description = "Это курс по химии"
                        //Image =  https://metanit.com/sharp/mvc5/24.8.php
                    }
                };
                    Courses.AddRange(list);
                    SaveChanges();
                }
                if (!lernens.Any())
                {
                    List<LernenItem> list = new List<LernenItem>
                    {
                    new LernenItem
                    {
                        idLernen = 1,
                        nameLernen = "1. Многообразие органического мира, основные таксономические категории. Принципы построения названий организмов. Вирусы, бактериофаги: строение и жизнедеятельность. Роль вирусов в природе, медицине и жизни человека. Основные заболевания, вызываемые вирусами.",
                        coursesItemId = 1
                    },
                       new LernenItem
                    {
                        idLernen = 2,
                           nameLernen = "2. Надцарство прокариоты: бактерии, цианобактерии. Строение и жизнедеятельность. Роль бактерий в природе, медицине и жизни человека. Основные заболевания, вызываемые бактериями.",
                           coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 3,
                        nameLernen = "3. Царство Протисты. Строение и жизнедеятельность гетеротрофных протистов (амеба обыкновенная, инфузория туфелька, фитофтора, малярийный плазмодий), одноклеточных и колониальных водорослей (эвглена зеленая, хламидомонада, хлорелла, вольвокс). Многоклеточные водоросли. Основные заболевания, вызываемые протистами.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 4,
                        nameLernen = "4. Царство Грибы. Общая характеристика: строение и жизнедеятельность. Роль грибов в природе, медицине и жизни человека. Мутуалистические взаимодействия грибов. Семейства паразитических грибов и основные заболевания, ими вызываемые. Шляпочные грибы. Плесневые грибы (мукор, пеницилл, аспергилл). Дрожжи.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 5,
                        nameLernen = "5. Общая характеристика растений. Основные разделы ботаники. Отличия низших и высших растений. Жизненные формы высших растений. Формы раздражимости. Значение в природе и жизни человека. Ткань: определение. Виды тканей высших растений. Сложные ткани (ксилема, флоэма, перидерма). Органы высших растений.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 6,
                        nameLernen = "6. Отдел Моховидные, общая характеристика, основные представители. Чередование поколений у мхов. Сравнительная характеристика кукушкина льна и сфагнума. Значение моховидных в природе и жизни человека.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 7,
                        nameLernen = "7. Отдел Папоротниковидные: общая характеристика, основные представители, чередование поколений. Отдел Плауновидные: общая характеристика, основные представители, чередование поколений. Отдел Хвощевидные: общая характеристика, основные представители, чередование поколений. Значение плауновидных, хвощевидных и папоротниковидных в природе и жизни человека.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 8,
                        nameLernen = "8. Отдел Голосеменные: общая характеристика, основные представители, чередование поколений. Значение голосеменных в природе и жизни человека.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 9,
                        nameLernen = "9. Вегетативные органы растений: корень. Виды корней. Корневая система. Видоизменения корней. Зоны корня. Поперечный срез корня. Основные виды удобрений.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 10,
                        nameLernen = "10. Вегетативные органы растений: побег. Почка: определение, основные классификации. Стебель: виды стеблей. Варианты ветвления стебля. Поперечный срез стебля. Особенности строения стеблей травянистых растений. Видоизменения побегов: подземные и надземные.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 11,
                        nameLernen = "11. Вегетативные органы растений: лист. Строения, основные классификации. Поперечный срез листа. Значение листопада. Вегетативное размножение",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 12,
                        nameLernen = "12. Генеративные органы растений: цветок. Строение цветка. Соцветия, их биологическое значение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 13,
                        nameLernen = "13. Опыление, виды опыления. Особенности ветроопыляемых и насекомоопыляемых цветков. Двойное оплодотворение. Образование семени и плода.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 14,
                        nameLernen = "14. Плод, виды плодов. Семя, различия семян однодольных и двудольных растений. Состав семян, условия их прорастания.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 15,
                        nameLernen = "15. Отдел Покрытосеменные: общая характеристика. Классы Однодольные и двудольные: их отличия, основные семейства. Значение различных семейств покрытосеменных в природе и жизни человека.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 16,
                        nameLernen = "16. Плод, виды плодов. Семя, различия семян однодольных и двудольных растений. Состав семян, условия их прорастания.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 17,
                        nameLernen = "17. Отдел Покрытосеменные: общая характеристика. Классы Однодольные и двудольные: их отличия, основные семейства. Значение различных семейств покрытосеменных в природе и жизни человека.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 18,
                        nameLernen = "18. Зоология: основые разделы зоологии. Сходства и отличия растений и животных. Основные классификации животных.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 19,
                        nameLernen = "19. Тип Кишечнополостные: основные ароморфозы, общая характеристика. Многообразие кишечнополостных. Значение кишечнополостных.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 20,
                        nameLernen = "20. Тип Плоские черви: основные ароморфозы, общая характеристика. Многообразие плоских червей. Циклы развития основных паразитических червей. Значение плоских червей.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 21,
                        nameLernen = "21. Тип Круглые черви: основные ароморфозы, общая характеристика. Многообразие круглых червей. Миграция личинки аскариды по организму. Значение круглых червей.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 22,
                        nameLernen = "22. Тип Кольчатые черви: основные ароморфозы, общая характеристика. Многообразие кольчатых червей. Дождевой червь. Значение кольчатых червей.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 23,
                        nameLernen = "23. Тип Моллюски: основные ароморфозы, общая характеристика. Многообразие моллюсков, их значение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 24,
                        nameLernen = "24. Тип Членистоногие: основные ароморфозы, общая характеристика. Класс Ракообразные: основные ароморфозы, общая характеристика. Многообразие ракообразных, их значение. Класс Паукообразные: основные ароморфозы, общая характеристика. Многообразие паукообразных, их значение. Класс Насекомые: основные ароморфозы, общая характеристика. Многообразие насекомых, их значение. Основные отряды насекомых: их характеристика.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 25,
                        nameLernen = "25. Тип Хордовые: основные ароморфозы, общая характеристика. Классификация типа хордовые. Класс Ланцентики: общая характеристика. Общая характеристика подтипа Позвоночные.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 26,
                        nameLernen = "26. Надкласс Рыбы: основные ароморфозы, общая характеристика. Хрящевые и костные рыбы: основные отряды, их значение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 27,
                        nameLernen = "27. Класс Земноводные: основные ароморфозы, общая характеристика. Многообразие земноводных: основные отряды, их значение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 28,
                        nameLernen = "28. Класс Пресмыкающиеся: основные ароморфозы, общая характеристика. Многообразие пресмыкающихся: основные отряды, их значение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 29,
                        nameLernen = "29. Класс Птицы: основные ароморфозы, общая характеристика. Многообразие птиц: основные отряды, их значение. Виды птенцов: особенности выводковых и гнездовых птенцов. Экологические группы птиц.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 30,
                        nameLernen = "30. Класс Млекопитающие: основные ароморфозы, общая характеристика. Подкласс Первозвери: особенности. Основные отряды подкласса Настоящие звери: их характеристика и значение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 31,
                        nameLernen = "31. Основные науки, изучающие человека. Анатомия человека: определение, основные разделы и методы изучения. Физиология человека: определение, основные разделы и методы изучения. Гигиена человека: определение, основные разделы и методы изучения.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 32,
                        nameLernen = "32. Клетка и ее производные. Ткани: основные виды. Органы, системы органов и аппараты.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 33,
                        nameLernen = "33. Нервная система: центральная и периферическая. Спинной мозг: анатомическая и физиологическая характеристика. Головной мозг: анатомическая и физиологическая характеристика. Вегетативная нервная система: анатомия, эффекты симпатического и парасимпатического отделов.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 34,
                        nameLernen = "34. Высшая нервная деятельность: безусловные и условные. Понятие доминанты. Сон: фазы сна. Память, виды памяти. Сознание.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 35,
                        nameLernen = "35. Дыхательная система. Органы дыхания, их строение и функции. Газообмен в органах и тканях. Механизм дыхательных движений. Жизненная емкость легких. Понятие о спирограмме. Нервная и гуморальная регуляция дыхания. Гигиена дыхательной системы.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 36,
                        nameLernen = "36. Опорно-двигательная система.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 37,
                        nameLernen = "37. Кровь",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 38,
                        nameLernen = "38. Кровообращение.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        nameLernen = "39. Дыхательная система.",
                        idLernen = 39,
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 40,
                        nameLernen = "40. Выделительная система.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 41,
                        nameLernen = "41. Кожа:",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 42,
                        nameLernen = "42. Эндокринная аппарат. Железы внутренней секреции. Значение желез внутренней секреции в гуморальной регуляции. Гормоны, их виды, свойства и функции. Взаимосвязь нервной и гуморальной регуляции функций организма.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 43,
                        nameLernen = "43. Половая система",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 44,
                        nameLernen = "44. Общая биология. Химический состав клетки.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 45,
                        nameLernen = "45. Строение клетки.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 46,
                        nameLernen = "46. Обмен веществ и энергии.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 47,
                        nameLernen = "47. Митотический цикл.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 48,
                        nameLernen = "48. Размножение организмов.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 49,
                        nameLernen = "49. Основы наследственности",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 50,
                        nameLernen = "50 Кроссинговер.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 51,
                        nameLernen = "51. Сцепление с полом.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 52,
                        nameLernen = "52. Изменчивость",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 53,
                        nameLernen = "53. Эволюция 1.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 54,
                        nameLernen = "54. Эволюция 2.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 55,
                        nameLernen = "55. Экология.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 56,
                        nameLernen = "56. Популяция.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 57,
                        nameLernen = "57. Биосфера.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 58,
                        nameLernen = "58. Вспомогательный раздел.",
                        coursesItemId = 1
                    },
                    new LernenItem
                    {
                        idLernen = 59,
                        nameLernen = "59. Примеры тестов.",
                        coursesItemId =1,
                    }
                    };
                    lernens.AddRange(list);
                    SaveChanges();
                }
                if (!test.Any())
                {
                    List<TestItem> tests = new List<TestItem>
                    {
                        new TestItem
                        {
                            idTest = 1,
                            NameThema = "Проверочный тест: Многообразие органического мира, основные таксономические категории. Принципы построения названий организмов.",
                            Courses = 1
                        },
                        new TestItem
                        {
                            idTest = 2,
                            NameThema = "Вирусы",
                            Courses = 1
                        },
                        new TestItem
                        {
                            idTest = 3,
                            NameThema = "Надцарство прокариоты: бактерии, цианобактерии. Строение и жизнедеятельность. Роль бактерий в природе, медицине и жизни человека. Основные заболевания, вызываемые бактериями",
                            Courses = 1
                        },
                        new TestItem
                        {
                            idTest = 4,
                            NameThema = "Протисты",
                            Courses = 1
                        }
                   };
                    test.AddRange(tests);
                    SaveChanges();
                }
                if (!questions.Any())
                {
                    List<QuestionItem> questionItems = new List<QuestionItem>
                    {
                        new QuestionItem
                        {
                            idQuestion = 1,
                            Answer = "вид",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 2,
                            Answer = "Вирусы",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 3,
                            Answer = "а,г",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 4,
                            Answer = "Протисты",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 5,
                            Answer = "а,в,д",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 6,
                            Answer = "а,в",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 7,
                            Answer = "Грибы",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 8,
                            Answer = "Эукариоты",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 9,
                            Answer = "Систематика",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 10,
                            Answer = "Все перечисленное верно.",
                            Test = 1
                        },
                        new QuestionItem
                        {
                            idQuestion = 11,
                            Answer = "Все перечисленное верно.",
                           Test = 1,
                        },
                    };
                    questions.AddRange(questionItems);
                    SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
                {
                    ErrorMessage.ErrorWrite("Object: " + validationError.Entry.Entity.ToString());
                    foreach (DbValidationError err in validationError.ValidationErrors)
                    {
                        ErrorMessage.ErrorWrite(err.ErrorMessage + "");
                    }
                }
            }
            catch (Exception e)
            {
                ErrorMessage.ErrorWrite(Convert.ToString(e));
            }
        }
    }
}