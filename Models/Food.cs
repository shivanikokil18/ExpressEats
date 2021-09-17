using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ExpressEats.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        [Required]
        public string DishName { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsDishOfTheWeek { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }
    }
}
