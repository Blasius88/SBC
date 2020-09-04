using System;
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
        public DbSet<CoursesItem> coursesTest { get; set; }
        public DbSet<TestItem> test { get; set; }
        public DbSet<QuestionItem> questions { get; set; }

        public DbSet<LernenItem> lernens { get; set; }
        public void Populate()
        {
            if (!coursesTest.Any())
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
