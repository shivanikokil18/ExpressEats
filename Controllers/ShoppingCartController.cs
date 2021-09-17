using ExpressEats.Models;
using ExpressEats.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFoodRepo _foodRepo;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IFoodRepo foodRepo, ShoppingCart shoppingCart)
        {
            _foodRepo = foodRepo;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel()
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()

            };

            return View(shoppingCartViewModel);

        }

        public RedirectToActionResult AddToShoppingCart(int foodId)
        {
            var selectedFood = _foodRepo.Allfoods.FirstOrDefault(p => p.FoodId == foodId);
            if (selectedFood != null)
            {
                _shoppingCart.AddToCart(selectedFood, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromCart(int foodId)
        {
            var selectedFood = _foodRepo.Allfoods.FirstOrDefault(p => p.FoodId == foodId);
            if (selectedFood != null)
            {
                _shoppingCart.RemoveFromCart(selectedFood);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult ClearCart()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            if (items != null)
            {
                _shoppingCart.ClearCart();
            }
            return RedirectToAction("Index");
        }
    }
}
