using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
