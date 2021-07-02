using FruitShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Fruit> FruitOnSale { get; set; }
        
    }
}
