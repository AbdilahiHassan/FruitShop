using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public interface IOrderRpository
    {
     void CreateOrder(Order order);
        

    }
}
