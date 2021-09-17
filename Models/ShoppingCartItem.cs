using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemid { get; set; }
        public Food Food { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
