using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.DataAccess.Concrete.EntityFramework.Context;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.Bussiness.Extensions
{
    public static class StartupIdentityResolvers
    {
        public static void AddIdentityConfigurations(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(opt => 
            {
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequiredLength = 1;
                opt.Password.RequireLowercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            }).AddEntityFrameworkStores<MyDataContext>();
        }

        public static void CookieConfigurations(this IServiceCollection services, string loginPath) 
        {
            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "FullCalendarCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict; 
                opt.Cookie.HttpOnly = true; 
                opt.ExpireTimeSpan = TimeSpan.FromDays(20);
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest; 
                opt.LoginPath = loginPath;
            });
        }
    }
}
