using ExpressEats.Models;
using ExpressEats.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace ExpressEats.Controllers
{
    public class FoodController : Controller
    {
        private readonly IFoodRepo _foodRepo;
        private readonly ICategoryRepo _categoryRepo;
       public FoodController(IFoodRepo foodRepo, ICategoryRepo categoryRepo)
        {
            _foodRepo = foodRepo;
            _categoryRepo = categoryRepo;
        }
        public IActionResult Index(string category)
        {
            IEnumerable<Food> foods;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                foods = _foodRepo.Allfoods.OrderBy(p => p.FoodId);
                currentCategory = "All Food";
            }
            else
            {
                foods = _foodRepo.Allfoods.Where(p => p.CategoryName == category);
                currentCategory = _categoryRepo.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }
            return View(new FoodsListViewModel
            {
                Foods = foods,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var food = _foodRepo.GetFoodById(id);
            if(food == null)
            {
                return NotFound();
            }
            return View(food);
        }

        [HttpGet]
        public ActionResult Search(string dish)
        {
            if (dish == null)
                return View(_foodRepo.Allfoods);
            var dishes = _foodRepo.GetListOfFood.Where(j => j.DishName.Contains(dish, StringComparison.OrdinalIgnoreCase));
            if (dishes.Count() == 0)
            {
                return RedirectToAction("FoodNotFound");
            }
            return View(dishes);
        }
        public ActionResult FoodNotFound()
        {
            return View();
        }
    }
}
