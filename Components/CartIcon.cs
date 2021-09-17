using ExpressEats.Models;
using ExpressEats.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Components
{
    public class CartIcon: ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;
        public CartIcon(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;

        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                //ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
