using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;
using ToDoList.WEB.Models;

namespace ToDoList.WEB.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var user = userManager.FindByNameAsync(userName).Result;
            var role = userManager.IsInRoleAsync(user, "Secretary").Result;
            var roleName = role ? "Secretary" : "Dentist";

            return RedirectToAction(roleName);
        }

        [Authorize(Roles = "Secretary")]
        public IActionResult Secretary()
        {
            var model = new SecretaryViewModel();
            var userName = User.Identity.Name;
            var user = userManager.FindByNameAsync(userName).Result;
            
            model.AppUser = user;
            model.Dentists = userManager.Users.Where(i => i.IsDentist == true).ToList();

            model.CollapseDentist = model.Dentists.Select(i => new SelectListItem {Value=i.Id.ToString(),Text=$"{i.Name} {i.Surname}"});

            return View(model);
        }

        [Authorize(Roles = "Dentist")]
        public IActionResult Dentist()
        {
            return View();
        }
    }
}
