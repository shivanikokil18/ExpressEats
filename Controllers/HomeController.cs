using Microsoft.AspNetCore.Mvc;
using ExpressEats.Models;
using ExpressEats.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodRepo _foodRepo;
        public HomeController(IFoodRepo foodRepo)
        {
            _foodRepo = foodRepo;

        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                FoodOfTheWeek = _foodRepo.FoodOfTheWeek
            };
            return View(homeViewModel);
        }
    }
}
