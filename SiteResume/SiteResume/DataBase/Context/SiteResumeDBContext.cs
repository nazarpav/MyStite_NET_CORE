using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SiteResume.DataBase.Entities;

namespace SiteResume.DataBase.Context
{
    public class SiteResumeDBContext : IdentityDbContext<User,Role,int, IdentityUserClaim<int>,UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public SiteResumeDBContext(DbContextOptions<SiteResumeDBContext> options) : base(options)
        {}
        public DbSet<AboutMe> AboutMe;
        public DbSet<_Layout> Layouts;
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
