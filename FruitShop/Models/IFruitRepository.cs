using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public interface IFruitRepository
    {
        IEnumerable<Fruit> GetAllFruits { get; }
        IEnumerable<Fruit> GetFruitOnsale { get; }
        Fruit GetFruitById(int fruitId);


    }
}
