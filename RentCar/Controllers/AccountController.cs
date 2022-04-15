using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RentCar.Data;
using RentCar.Models.ViewModels.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        //***** Login *****//
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid credentials");
                return View();
            }

            var signinResult = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

            if (!signinResult.Succeeded)
            {
                ModelState.AddModelError("", "invalid credentials");
                return View();
            }

            return RedirectToAction("Index", "Home");
        }


        //***** Logout *****//

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


        //***** Register *****//
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var dbUser = await _userManager.FindByNameAsync(model.UserName);

            if (dbUser != null)
            {
                ModelState.AddModelError(nameof(RegisterViewModel.UserName),
                    "Bu adda istifadəçi artıq mövcuddur");
                return View();
            }

            IdentityUser newUser = new IdentityUser
            {
                UserName = model.UserName,
                Email = model.Email
            };

            var identityResult = await _userManager.CreateAsync(newUser, model.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var item in identityResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }

                return View();
            }

            await _userManager.AddToRoleAsync(newUser, RoleConstants.User);
            await _signInManager.SignInAsync(newUser, true);

            return RedirectToAction("Index", "Home");
        }
    }
}
