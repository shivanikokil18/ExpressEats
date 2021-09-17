using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public class ShoppingCart
    {
        private readonly FoodDbContext _foodDbContext;

        public string ShoppingCartId { get; set; }

        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public ShoppingCart(FoodDbContext foodDbContext)
        {
            _foodDbContext = foodDbContext;
        }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<FoodDbContext>();

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };

        }

        public void AddToCart(Food food, int amount)
        {
            var shoppingCartItem =
                _foodDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Food.FoodId == food.FoodId && s.ShoppingCartId == ShoppingCartId);
            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Food = food,
                    Amount = 1
                };
                _foodDbContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _foodDbContext.SaveChanges();
        }
        public int RemoveFromCart(Food food)
        {
            var shoppingCartItem =
                _foodDbContext.ShoppingCartItems.SingleOrDefault(
                    s => s.Food.FoodId == food.FoodId && s.ShoppingCartId == ShoppingCartId);
            var localamount = 0;
            if (shoppingCartItem == null)
            {
                if(shoppingCartItem.Amount > 1)
                {
                    shoppingCartItem.Amount--;
                    localamount = shoppingCartItem.Amount;
                }
            }
            else
            {
                _foodDbContext.ShoppingCartItems.Remove(shoppingCartItem);
            }
            _foodDbContext.SaveChanges();
            return localamount;
        }

        public void ClearCart()
        {
            var shoppingCartItemsList = ShoppingCartItems ?? (
                ShoppingCartItems = _foodDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId).Include(s => s.Food).ToList());

            if (shoppingCartItemsList == null)
                return;

            foreach (var item in shoppingCartItemsList)
            {
                _foodDbContext.ShoppingCartItems.Remove(item);
            }
            _foodDbContext.SaveChanges();
        }
        public List<ShoppingCartItem> GetShoppingCartItems()
        {
            return ShoppingCartItems ?? (
                ShoppingCartItems = _foodDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Include(s => s.Food)
                .ToList());
        }

        public decimal GetShoppingCartTotal()
        {
            var ShoppingCartItems =
                _foodDbContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
               .Include(s => s.Food).ToList();
            decimal total = 0;
            if (ShoppingCartItems == null)
                return 0;
            foreach (var item in ShoppingCartItems)
            {
                total = total + (item.Amount * item.Food.Price);
            }
            return total;
        }

    }
}
