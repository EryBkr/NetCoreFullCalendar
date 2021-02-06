using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;

namespace ToDoList.WEB.Functions
{
    public static class IdentityInitilaizer
    {
        public static async Task SeedData(UserManager<AppUser> user, RoleManager<AppRole> role)
        {
            var secRole = await role.FindByNameAsync("Secretary");
            if (secRole == null)
            {
                await role.CreateAsync(new AppRole { Name = "Secretary" });
            }
            var dentistRole = await role.FindByNameAsync("Dentist");
            if (dentistRole == null)
            {
                await role.CreateAsync(new AppRole { Name = "Dentist" });
            }

            //Add Secretary
            var secUser = await user.FindByNameAsync("Blackerback");
            if (secUser == null)
            {
                var appUser = new AppUser
                {
                    UserName = "Blackerback",
                    Name = "Eray",
                    Surname = "Bakır",
                    Email = "eray.bkr94@gmail.com"
                };
                await user.CreateAsync(appUser, "1");
                await user.AddToRoleAsync(appUser, "Secretary");
            }

            //Add Dentist
            var dentistUser = await user.FindByNameAsync("Dentist_1");
            if (dentistUser == null)
            {
                var appUser = new AppUser
                {
                    UserName = "Dentist_1",
                    Name = "Doktor",
                    Surname = "Mouse",
                    Email = "crazyeray94@gmail.com"
                };
                await user.CreateAsync(appUser, "1");
                await user.AddToRoleAsync(appUser, "Dentist");
            }
        }
    }
}
