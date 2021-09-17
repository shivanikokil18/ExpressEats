using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressEats.Models;

namespace ExpressEats.Models
{
    public class FoodDbContext:DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options):base(options)
        {

        }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seeding the db
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Snacks", Description = "The most versatile and fresh medium" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Lunch", Description = "The most versatile and fresh medium" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Dinner", Description = "The most versatile and fresh medium" });

            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 1,
                     DishName = "Pohe",
                     Price = 15,
                     ShortDescription = "Teasty Snacks",
                     LongDescription = "Best Snacks for hunger",
                     CategoryName = "Snacks",
                     ImageUrl = "/images/Poha.jpg",
                     IsDishOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Poha.jpg"
                 });

            modelBuilder.Entity<Food>().HasData(

          new Food
          {
              FoodId = 2,
              DishName = "Biryani",
              Price = 180,
              ShortDescription = "Veg Biryani",
              LongDescription = "Rich Spicy flavoured veg biryani",
              CategoryName = "Lunch",
              ImageUrl = "/images/Biryani.jpg",
              IsDishOfTheWeek = true,
              ImageThumbnailUrl = "/images/Biryani.jpg"
          });
            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 3,
                     DishName = "Vadapav",
                     Price = 15,
                     ShortDescription = "Teasty Snacks",
                     LongDescription = "Mumbai special vadapav",
                     CategoryName = "Snacks",
                     ImageUrl = "/images/vadapav.jpg",
                     IsDishOfTheWeek = true,
                     ImageThumbnailUrl = "/images/vadapav.jpg"
                 });
            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 4 ,
                     DishName = "Pizza",
                     Price = 150,
                     ShortDescription = "Veg Paradise Pizza",
                     LongDescription = "Pizza with topping of veggies",
                     CategoryName = "Dinner",
                     ImageUrl = "/images/Pizza.jpg",
                     IsDishOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Pizza.jpg"
                 });
            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 5,
                     DishName = "Noodles",
                     Price = 165,
                     ShortDescription = "Spicy Veg Noodles",
                     LongDescription = "Spicy noodles with fresh veggies",
                     CategoryName = "Dinner",
                     ImageUrl = "/images/Noodles.jpg",
                     IsDishOfTheWeek = true,
                     ImageThumbnailUrl = "/images/Noodles.jpg"
                 });
            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 6,
                     DishName = "Kulcha",
                     Price = 45,
                     ShortDescription = "Hot Kulcha",
                     LongDescription = "Hot kulcha for lunch",
                     CategoryName = "Lunch",
                     ImageUrl = "/images/Kulcha.jpg",
                     IsDishOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Kulcha.jpg"
                 });
            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 7,
                     DishName = "Pasta",
                     Price = 50,
                     ShortDescription = "Teasty pasta",
                     LongDescription = "Spicy red sauce pasta with veggies",
                     CategoryName = "Snacks",
                     ImageUrl = "/images/Pasta.jpg",
                     IsDishOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Pasta.jpg"
                 });
            modelBuilder.Entity<Food>().HasData(

                 new Food
                 {
                     FoodId = 8,
                     DishName = "Spaghetti",
                     Price = 80,
                     ShortDescription = "Teasty Snacks",
                     LongDescription = "spaghetti With veggies",
                     CategoryName = "Snacks",
                     ImageUrl = "/images/Spaghetti.jpg",
                     IsDishOfTheWeek = false,
                     ImageThumbnailUrl = "/images/Spaghetti.jpg"
                 });

        }

        public DbSet<ExpressEats.Models.Order> Order { get; set; }

    }
}
