using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }
        public DbSet<Fruit> Fruties { get; set; }
        public DbSet<Category> Categories { get; set; }
       public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Fruit Banana" });

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Fruit Apple" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Fruit Pineapple" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Fruit Grape" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 5, CategoryName = "Fruit Watermelon" });
           
            modelBuilder.Entity<Fruit>().HasData(new {
                FruitId = 1,
                Name ="mixed fruit",
                Price = 2.95,
                Description = "To be Health as a person is the best hole in tire life On this Page you " + "" +
                "can find the natural fruit that can lead you a good health",
                CategoryId =1,
                ImageUrl= "/Images/thumbnails/Logo.png",
                ImagethumnailUrl = "/Images/thumbnails/ImagethumnailUrl.jpg",
                IsOnSale = false,
                IsInStock = true
            });


            modelBuilder.Entity<Fruit>().HasData(new
            {
                FruitId = 2,
                Name = "mixed fruit",
                Price = 2.95,
                Description = "To be Health as a person is the best hole in tire life On this Page you " + "" +
             "can find the natural fruit that can lead you a good health",
                CategoryId = 1,
                ImageUrl = "/Images/thumbnails/Logo.png",
                ImagethumnailUrl = "/Images/thumbnails/Banana.jpg",
                IsOnSale = true,
                IsInStock = true
            });
            modelBuilder.Entity<Fruit>().HasData(new
            {
                FruitId = 3,
                Name = "mixed fruit",
                Price = 3.95,
                Description = "To be Health as a person is the best hole in tire life On this Page you " + "" +
             "can find the natural fruit that can lead you a good health",
                CategoryId = 1,
                ImageUrl = "/Images/thumbnails/Logo.png",
                ImagethumnailUrl = "/Images/thumbnails/Red_Apple.jpg",
                IsOnSale = false,
                IsInStock = true
            });
            modelBuilder.Entity<Fruit>().HasData(new
            {
                FruitId = 4,
                Name = "mixed fruit",
                Price = 4.95,
                Description = "To be Health as a person is the best hole in tire life On this Page you " + "" +
             "can find the natural fruit that can lead you a good health",
                CategoryId = 2,
                ImageUrl = "/Images/thumbnails/Logo.png",
                ImagethumnailUrl = "/Images/thumbnails/ImagethumnailUrl.jpg",
                IsOnSale = true,
                IsInStock = false
            });
            modelBuilder.Entity<Fruit>().HasData(new
            {
                FruitId = 5,
                Name = "mixed fruit",
                Price = 5.95,
                Description = "To be Health as a person is the best hole in tire life On this Page you " + "" +
             "can find the natural fruit that can lead you a good health",
                CategoryId = 2,
                ImageUrl = "/Images/thumbnails/Logo.png",
                ImagethumnailUrl = "/Images/thumbnails/ImagethumnailUrl.jpg",
                IsOnSale = true,
                IsInStock = true
            });

        }


    }
}
