using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public interface IFoodRepo
    {
        IEnumerable<Food> Allfoods { get; }
        IEnumerable<Food> FoodOfTheWeek { get; }
        public IEnumerable<Food> GetListOfFood{ get; }
        Food GetFoodById(int FoodID);

    }
}
