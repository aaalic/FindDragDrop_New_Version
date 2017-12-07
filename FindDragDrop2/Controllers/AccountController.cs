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

        // GET: /<controller>/
        public IActionResult Index()
        {
            //var result = await userManager.CreateAsync(
            //new IdentityUser("admin"), "Password123!");

            return Content("Hejsan");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult LogIn()
        {
            return View();
        }
        //sdkjfsdkf
     

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

            return RedirectToAction(nameof(Index));
        }
    }
}
