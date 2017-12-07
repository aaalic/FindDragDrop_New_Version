using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FindDragDrop2.Models.Entities;
using FindDragDrop2.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FindDragDrop2.Controllers
{
    
    public class HomeController : Controller
    {
        FindDragDropContext context;

        public HomeController(FindDragDropContext context)
        {
            this.context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new IndexVM
            {
                Name = User.Identity.Name //Read from auth cookie
            };
            return View(model);
        }

        public IActionResult GetItems()
        {
            var viewModel = context.GetAllItems();
            return PartialView("_Partial", viewModel);
        }
    }
}
