using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Models
{
    public class ShoppingCartItem
    {
   
        [Key]
        public int ShoppinCartItemId { get; set; }
        
        public string ShoppingCartId { get; set; }
        public Fruit Fruit { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
    }
}
