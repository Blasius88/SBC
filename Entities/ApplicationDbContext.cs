using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SBC.Models;

namespace SBC.DAL
{
    public partial class ApplicationDbContext
    {
        public DbSet<CoursesTest> coursesTest { get; set; }
        public DbSet<Test> test { get; set; }
        public DbSet<Question> questions { get; set; }

        public void Populate()
        {
            if (!coursesTest.Any())
            {
                List<CoursesTest> list = new List<CoursesTest> 
                {
                    new CoursesTest
                    {
                        id  =1,
                        NameCourses = "Биология"
                    },
                     new CoursesTest
                    {
                        id  =2,
                        NameCourses = "Химия"
                    }
                };
                coursesTest.AddRange(list);
                SaveChanges();
            }
            if (!Roles.Any())
            {
                // Создаем менеджеры ролей и пользователей
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(this));
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this));
                // Создаем роли "admin" и "user"
                roleManager.Create(new IdentityRole("admin"));
                roleManager.Create(new IdentityRole("user"));
                roleManager.Create(new IdentityRole("teacher"));
                // Создаем пользователя
                var userAdmin = new ApplicationUser
                {
                    Email = "admSBComp@gmail.com",
                    UserName = "admin",
                    NickName = "SuperHero"
                };
                userManager.CreateAsync(userAdmin, "SuperHero").Wait();
                // Добавляем созданного пользователя в администраторы
                userManager.AddToRole(userAdmin.Id, "admin");
            }
        }
    }
}
