using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SiteResume.DataBase.Entities;
using System;
namespace SiteResume.DataBase.Context
{
    public class SiteResumeDBSeeder
    {
        public static void SeedData(IServiceProvider services, IWebHostEnvironment env, IConfiguration config)
        {
            using (var scope = services.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var manager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();
                var managerRole = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
                var context = scope.ServiceProvider.GetRequiredService<SiteResumeDBContext>();
                var roleName = "Admin";
                var result = managerRole.CreateAsync(new Role
                {
                    Name = roleName
                }).Result;
                var user = new User
                {
                    Email = "1",
                    UserName = "Nazar",
                    PhoneNumber = "+11(111)111-11-11"
                };
                result = manager.CreateAsync(user, "qwe123").Result;
                result = manager.AddToRoleAsync(user, roleName).Result;
            }
        }
    }
}
