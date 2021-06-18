using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class FruitRepository : IFruitRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        public IEnumerable<Fruit> GetAllFruits => new List<Fruit>
        {
            new Fruit{FruitId=1, Name="Assorted fruit",Price =2.85M,
                Description="This fruit it is orgin and have very  hight quilty",
                Category = _categoryRepository.GetAllCategories.ToList()[0],
                ImageUrl="https://www.fruktdirekt.se/fruktfakta/%C3%A4pplen",IsInStock=true,IsOnSale=false,
           ImagethumnailUrl = "https://www.pngwing.com/en/free-png-zofin" },

             new Fruit{FruitId=2, Name="Assorted fruit",Price =3.85M,
                Description="This fruit it is orgin and have very  hight quilty",
                Category = _categoryRepository.GetAllCategories.ToList()[1],
                ImageUrl="https://www.fruktdirekt.se/fruktfakta/%C3%A4pplen",IsInStock=true,IsOnSale=false,
           ImagethumnailUrl = "https://www.pngwing.com/en/free-png-zofin" },

              new Fruit{FruitId=3, Name="Assorted fruit",Price =4.85M,
                Description="This fruit it is orgin and have very  hight quilty",
                Category = _categoryRepository.GetAllCategories.ToList()[2],
                ImageUrl="https://www.fruktdirekt.se/fruktfakta/%C3%A4pplen",IsInStock=true,IsOnSale=true,
            ImagethumnailUrl = "https://www.pngwing.com/en/free-png-zofin" }


        };

        public IEnumerable<Fruit> GetFruitOnsale => throw new NotImplementedException();

        public Fruit GetFruitById(int fruitId)
        {
            return GetAllFruits.FirstOrDefault(c => c.FruitId == fruitId);
        }
    }
}
