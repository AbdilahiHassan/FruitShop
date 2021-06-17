﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Apple", CategoryDescription="SweetApple"},
                        new Category{CategoryId=2,CategoryName="Banana", CategoryDescription="Delicious bana"},
                                    new Category{CategoryId=3,CategoryName="strawberry", CategoryDescription="sour strawberry"}
      };
    }
}
