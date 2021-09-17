﻿// <auto-generated />
using System;
using ExpressEats.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ExpressEats.Migrations
{
    [DbContext(typeof(FoodDbContext))]
    [Migration("20210915195516_registerupdate")]
    partial class registerupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ExpressEats.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Snacks",
                            Description = "The most versatile and fresh medium"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Lunch",
                            Description = "The most versatile and fresh medium"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Dinner",
                            Description = "The most versatile and fresh medium"
                        });
                });

            modelBuilder.Entity("ExpressEats.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDishOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Foods");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            CategoryName = "Snacks",
                            DishName = "Pohe",
                            ImageThumbnailUrl = "/images/Poha.jpg",
                            ImageUrl = "/images/Poha.jpg",
                            IsDishOfTheWeek = false,
                            LongDescription = "Best Snacks for hunger",
                            Price = 15m,
                            ShortDescription = "Teasty Snacks"
                        },
                        new
                        {
                            FoodId = 2,
                            CategoryName = "Lunch",
                            DishName = "Biryani",
                            ImageThumbnailUrl = "/images/Biryani.jpg",
                            ImageUrl = "/images/Biryani.jpg",
                            IsDishOfTheWeek = true,
                            LongDescription = "Rich Spicy flavoured veg biryani",
                            Price = 180m,
                            ShortDescription = "Veg Biryani"
                        },
                        new
                        {
                            FoodId = 3,
                            CategoryName = "Snacks",
                            DishName = "Vadapav",
                            ImageThumbnailUrl = "/images/vadapav.jpg",
                            ImageUrl = "/images/vadapav.jpg",
                            IsDishOfTheWeek = true,
                            LongDescription = "Mumbai special vadapav",
                            Price = 15m,
                            ShortDescription = "Teasty Snacks"
                        },
                        new
                        {
                            FoodId = 4,
                            CategoryName = "Dinner",
                            DishName = "Pizza",
                            ImageThumbnailUrl = "/images/Pizza.jpg",
                            ImageUrl = "/images/Pizza.jpg",
                            IsDishOfTheWeek = false,
                            LongDescription = "Delicious pizza with topping of veggies",
                            Price = 150m,
                            ShortDescription = "Veg Paradise Pizza"
                        },
                        new
                        {
                            FoodId = 5,
                            CategoryName = "Dinner",
                            DishName = "Noodles",
                            ImageThumbnailUrl = "/images/Noodles.jpg",
                            ImageUrl = "/images/Noodles.jpg",
                            IsDishOfTheWeek = true,
                            LongDescription = "Spicy noodles with fresh veggies",
                            Price = 165m,
                            ShortDescription = "Spicy Veg Noodles"
                        },
                        new
                        {
                            FoodId = 6,
                            CategoryName = "Lunch",
                            DishName = "Kulcha",
                            ImageThumbnailUrl = "/images/Kulcha.jpg",
                            ImageUrl = "/images/Kulcha.jpg",
                            IsDishOfTheWeek = false,
                            LongDescription = "Hot kulcha for lunch",
                            Price = 45m,
                            ShortDescription = "Hot Kulcha"
                        },
                        new
                        {
                            FoodId = 7,
                            CategoryName = "Snacks",
                            DishName = "Pasta",
                            ImageThumbnailUrl = "/images/Pasta.jpg",
                            ImageUrl = "/images/Pasta.jpg",
                            IsDishOfTheWeek = false,
                            LongDescription = "Spicy red sauce pasta ",
                            Price = 50m,
                            ShortDescription = "Teasty pasta"
                        },
                        new
                        {
                            FoodId = 8,
                            CategoryName = "Snacks",
                            DishName = "Spaghetti",
                            ImageThumbnailUrl = "/images/Spaghetti.jpg",
                            ImageUrl = "/images/Spaghetti.jpg",
                            IsDishOfTheWeek = false,
                            LongDescription = "spaghetti With veggies",
                            Price = 80m,
                            ShortDescription = "Teasty Snacks"
                        });
                });

            modelBuilder.Entity("ExpressEats.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Pincode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("OrderId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ExpressEats.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemid");

                    b.HasIndex("FoodId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ExpressEats.Models.Food", b =>
                {
                    b.HasOne("ExpressEats.Models.Category", "Category")
                        .WithMany("Foods")
                        .HasForeignKey("CategoryId");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ExpressEats.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ExpressEats.Models.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.Navigation("Food");
                });

            modelBuilder.Entity("ExpressEats.Models.Category", b =>
                {
                    b.Navigation("Foods");
                });
#pragma warning restore 612, 618
        }
    }
}
