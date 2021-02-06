using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Bussiness.ValidationRules.FluentValidation.AppUser;
using ToDoList.Entities.DTO;

namespace ToDoList.Bussiness.Extensions
{
    public static class StartupValidatorResolvers
    {
        public static void ValidatorConfigurations(this IServiceCollection services)
        {
           
            services.AddTransient<IValidator<UserAddDto>, UserAddValidator>();
            services.AddTransient<IValidator<UserSignInDto>, UserSignInValidator>();
            services.AddTransient<IValidator<UserUpdateDto>, UserUpdateValidator>();
  
        }
    }
}
