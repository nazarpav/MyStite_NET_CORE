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
            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });
                userRole.HasOne(ur => ur.Role).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.RoleId).IsRequired();
                userRole.HasOne(ur => ur.User).WithMany(r => r.UserRoles).HasForeignKey(ur => ur.UserId).IsRequired();
            });
        }
    }
}
