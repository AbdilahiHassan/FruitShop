using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderId { get; set; }
        public int FruitId { get; set; }
        public  Fruit Fruit{ get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public Order Order { get; set; }
    }
}
