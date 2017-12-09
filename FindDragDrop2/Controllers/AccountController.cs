using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDragDrop2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FindDragDrop2.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        UserManager<IdentityUser> userManager;
        SignInManager<IdentityUser> signInManager;
        RoleManager<IdentityRole> roleManager;
        //IdentityDbContext identityContext;

        public AccountController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager
            /*IdentityDbContext identityContext*/)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            //this.identityContext = identityContext;

            //identityContext.Database.EnsureCreated();
        }
       

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create(CreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var result = await userManager.CreateAsync(
            new IdentityUser(viewModel.Name), viewModel.Password);

            if(result.Succeeded)
            {
               var resultLogin = await signInManager.PasswordSignInAsync(
               viewModel.Name, viewModel.Password, false, false);

            }
            else
            {
                ModelState.AddModelError(
                     nameof(CreateVM.Name), "The username is already taken");
                return View(viewModel);
            }

            return RedirectToAction("Menu", "Home");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> LogIn(LoginVM viewModel)
        {
            if (!ModelState.IsValid)
                return View(viewModel);

            var result = await signInManager.PasswordSignInAsync(
                viewModel.Name, viewModel.Password, false, false); //Ifall användaren finns skapas kakan

            if (!result.Succeeded)
            {
                ModelState.AddModelError(
                    nameof(LoginVM.Name), "Invalid username or password");
                return View(viewModel);
            }

            return RedirectToAction("Menu", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            
            return RedirectToAction("Login", "Account");
        }


    }
}
