using FruitShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.ViewModels
{
    public class FruitListVeiwModel
    {
        public IEnumerable<Fruit> Fruities { get; set; }
        public string CurrentCategory  { get; set; }

    }
}
