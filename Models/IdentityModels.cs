using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace getfitEF.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("getfitEF", throwIfV1Schema: false)
        {
        }

        public object Korisnik { get; internal set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<getfitEF.Models.Korisnik> Korisniks { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.SifSpol> SifSpols { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.Zaposlenik> Zaposleniks { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.Teretana> Teretanas { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.SifTeretana> SifTeretanas { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.ZaposlenikUser> ZaposlenikUsers { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.UplataIsplata> UplataIsplatas { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.SifGodina> SifGodinas { get; set; }

        public System.Data.Entity.DbSet<getfitEF.Models.SifMjesec> SifMjesecs { get; set; }
    }
}