using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketMicroservice.Web
{
    public static class InitDbExtensions
    {
        public static IApplicationBuilder InitDb(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var userManager = services.GetService<UserManager<IdentityUser>>();
                var roleManager = services.GetService<RoleManager<IdentityRole>>();

                if (userManager.Users.Count() == 0)
                {
                    Task.Run(() => InitRoles(roleManager)).Wait();
                    Task.Run(() => InitUsers(userManager)).Wait();
                }

            }
            return app;
        }
        private static async Task InitRoles(RoleManager<IdentityRole> roleManager)
        {
            try
            {
                var role = new IdentityRole("Admin");
                await roleManager.CreateAsync(role);

                role = new IdentityRole("User");
                await roleManager.CreateAsync(role);

                role = new IdentityRole("Supervisor");
                await roleManager.CreateAsync(role);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        private static async Task InitUsers(UserManager<IdentityUser> userManager)
        {
            var user = new IdentityUser()
            {
                UserName = "admin@ticket.com",
                Email = "admin@ticket.com",
                PhoneNumber = "123456789"
            };
            await userManager.CreateAsync(user, "t%(ketM1cros3rVICE");
            await userManager.AddToRoleAsync(user, "Admin");
        }
        public static Int64 ToUnixEpochDate(this DateTime dateTime)
        {
            var result = (Int64)Math.Round((dateTime.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);
            return result;
        }
    }
}