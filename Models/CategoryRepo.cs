using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public class CategoryRepo:ICategoryRepo
    {
            private readonly FoodDbContext _foodDbContext;

            public CategoryRepo(FoodDbContext foodDbContext)
            {
                _foodDbContext = foodDbContext;
            }

            public IEnumerable<Category> AllCategories => _foodDbContext.Categories;
        
    }
}
