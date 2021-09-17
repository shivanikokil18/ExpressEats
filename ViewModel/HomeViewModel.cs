using ExpressEats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Food> FoodOfTheWeek { get; set; }
    }
}
