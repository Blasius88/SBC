using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SBC.Entities
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            userIdentity.AddClaim(new Claim("nick", this.NickName));
            userIdentity.AddClaim(new Claim("LastName", this.LastName));
            userIdentity.AddClaim(new Claim("FirstName", this.FirstName));
            return userIdentity;
        }
        public string NickName { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }

    public partial class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Populate();
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}