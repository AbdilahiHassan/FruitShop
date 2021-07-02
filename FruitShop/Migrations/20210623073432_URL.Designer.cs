﻿// <auto-generated />
using FruitShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FruitShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210623073432_URL")]
    partial class URL
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FruitShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Fruit Banana"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Fruit Apple"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Fruit Pineapple"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Fruit Grape"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Fruit Watermelon"
                        });
                });

            modelBuilder.Entity("FruitShop.Models.Fruit", b =>
                {
                    b.Property<int>("FruitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagethumnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsInStock")
                        .HasColumnType("bit");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("FruitId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Fruties");

                    b.HasData(
                        new
                        {
                            FruitId = 1,
                            CategoryId = 1,
                            Description = "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health",
                            ImageUrl = "/Images/thumbnails/Logo.png",
                            ImagethumnailUrl = "/Images/thumbnails/ImagethumnailUrl.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "mixed fruit",
                            Price = 2.95m
                        },
                        new
                        {
                            FruitId = 2,
                            CategoryId = 1,
                            Description = "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health",
                            ImageUrl = "/Images/thumbnails/Logo.png",
                            ImagethumnailUrl = "/Images/thumbnails/Banana.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "mixed fruit",
                            Price = 2.95m
                        },
                        new
                        {
                            FruitId = 3,
                            CategoryId = 1,
                            Description = "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health",
                            ImageUrl = "/Images/thumbnails/Logo.png",
                            ImagethumnailUrl = "/Images/thumbnails/Red_Apple.jpg",
                            IsInStock = true,
                            IsOnSale = false,
                            Name = "mixed fruit",
                            Price = 3.95m
                        },
                        new
                        {
                            FruitId = 4,
                            CategoryId = 2,
                            Description = "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health",
                            ImageUrl = "/Images/thumbnails/Logo.png",
                            ImagethumnailUrl = "/Images/thumbnails/ImagethumnailUrl.jpg",
                            IsInStock = false,
                            IsOnSale = true,
                            Name = "mixed fruit",
                            Price = 4.95m
                        },
                        new
                        {
                            FruitId = 5,
                            CategoryId = 2,
                            Description = "To be Health as a person is the best hole in tire life On this Page you can find the natural fruit that can lead you a good health",
                            ImageUrl = "/Images/thumbnails/Logo.png",
                            ImagethumnailUrl = "/Images/thumbnails/ImagethumnailUrl.jpg",
                            IsInStock = true,
                            IsOnSale = true,
                            Name = "mixed fruit",
                            Price = 5.95m
                        });
                });

            modelBuilder.Entity("FruitShop.Models.Fruit", b =>
                {
                    b.HasOne("FruitShop.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
