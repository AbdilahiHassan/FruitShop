using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class Fruit
    {
        public int FruitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImagethumnailUrl { get; set; }
        public bool IsOnSale { get; set; } //change to doulbe
        public bool IsInStock { get; set; }
        public int CategoryId { get; set; }
        public Category  Category { get; set; }
    }
}
