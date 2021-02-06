using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Bussiness.Extensions;
using ToDoList.Bussiness.Extensions.DIResolvers;
using ToDoList.DataAccess.Concrete.EntityFramework.Context;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;
using ToDoList.WEB.Functions;

namespace ToDoList.WEB
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews().AddFluentValidation();
            services.AddContainerWithDependencies();
            services.AddDbContext<MyDataContext>();
            services.AddIdentityConfigurations();
            services.CookieConfigurations("/Account/LogIn");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            IdentityInitilaizer.SeedData(userManager, roleManager).Wait();

            app.UseRouting();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
                     (
                     name: "default",
                     pattern: "{controller=Profile}/{action=Index}/{id?}"
                     );
            });
        }
    }
}
