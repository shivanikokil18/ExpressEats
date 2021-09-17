using System;
using ExpressEats.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.ViewModel
{
    public class FoodsListViewModel
    {
        public IEnumerable<Food> Foods { get; set; }

        public string CurrentCategory { get; set; }
    }
}
