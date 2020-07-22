using System.Linq;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SBC.DAL
{
    public partial class ApplicationDbContext
    {
        public void Populate()
        {
            if (!Roles.Any())
            {
                // Создаем менеджеры ролей и пользователей
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(this));
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(this));
                // Создаем роли "admin" и "user"
                roleManager.Create(new IdentityRole("admin"));
                roleManager.Create(new IdentityRole("user"));
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
