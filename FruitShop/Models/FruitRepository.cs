using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class FruitRepository : IFruitRepository
    {
        // private readonly ICategoryRepository _categoryRepository = new CategoryRepository();
        private readonly AppDbContext _appDbContext;
        public FruitRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Fruit> GetAllFruits 

        {
            get
            {
                return _appDbContext.Fruties.Include(c => c.Category);
            }

        }


        public IEnumerable<Fruit> GetFruitOnsale
        {
            get
            {
                return _appDbContext.Fruties.Include(c => c.Category).Where(P =>P.IsOnSale);
            }
            }

    public Fruit GetFruitById(int fruitId)
        {
            return GetAllFruits.FirstOrDefault(c => c.FruitId == fruitId);
        }
    }
}
