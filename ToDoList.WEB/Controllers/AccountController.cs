using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoList.Bussiness.Abstract;
using ToDoList.Entities.Concrete.IdentityLibraryEntites;
using ToDoList.Entities.DTO;

namespace ToDoList.WEB.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<AppUser> signInManager;
        private readonly IAutoMapperService mapper;
        private readonly UserManager<AppUser> userManager;

        public AccountController(SignInManager<AppUser> signInManager, IAutoMapperService mapper, UserManager<AppUser> userManager)
        {
            this.signInManager = signInManager;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(UserSignInDto model)
        {
            var user = await userManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await signInManager.PasswordSignInAsync(user.UserName, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles.Contains("Secretary"))
                        return RedirectToAction("Index", "Profile");
                    else
                        return RedirectToAction("Index", "Profile");
                }
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserAddDto model)
        {
            var user = mapper.Mapper.Map<AppUser>(model);
            var result = await userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                var role=model.IsDentist?"Dentist":"Secretary";
                var roleResult = await userManager.AddToRoleAsync(user, role);
                if (roleResult.Succeeded)
                {
                    return RedirectToAction("LogIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(model);
        }

        public async Task<IActionResult> LogOut()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("LogIn");
        }



    }
}
