using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Bussiness.Abstract;
using ToDoList.Bussiness.Concrete;
using ToDoList.DataAccess.Abstract;
using ToDoList.DataAccess.Concrete.EntityFramework;

namespace ToDoList.Bussiness.Extensions.DIResolvers
{
    public static class StartupDIResolvers
    {
        public static void AddContainerWithDependencies(this IServiceCollection services)
        {
           
            services.AddScoped<IAppUserService, AppUserService>();
            services.AddScoped<IAppUserDal, EfUserDal>();

            services.AddScoped<IAppointmentDal, EfAppointmentDal>();
            services.AddScoped<IAppointmentService, AppointmentService>();

            services.AddTransient<IAutoMapperService, AutoMapperService>();
        }
    }
}
