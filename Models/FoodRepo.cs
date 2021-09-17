using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public class FoodRepo:IFoodRepo
    {
        private readonly FoodDbContext _foodDbContext;

        public FoodRepo(FoodDbContext foodDbContext)
        {
            _foodDbContext = foodDbContext;
        }


        public IEnumerable<Food> Allfoods
        {
            get
            {
                return _foodDbContext.Foods.Include(c => c.Category);
            }
        }

        public IEnumerable<Food> FoodOfTheWeek
        {
            get
            {
                return _foodDbContext.Foods.Include(c => c.Category).Where(p => p.IsDishOfTheWeek);
            }
        }


        public IEnumerable<Food> GetListOfFood => _foodDbContext.Foods;

        public Food GetFoodById(int FoodID)
        {
            return Allfoods.FirstOrDefault(p => p.FoodId == FoodID);
        }
    }
}
