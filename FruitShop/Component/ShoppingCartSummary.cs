using FruitShop.Models;
using FruitShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Component
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        //invoke method it isnvoking automaticaly asp
        //when the viewcomponent is place inside the view
        public IViewComponentResult Invoke()
        {
            _shoppingCart.shoppingCartItems = _shoppingCart.GetShoppingCartItems(); //what ever is returning our shoppingCartItems
            // in this class contains coppingCart and shoppingCartTotal
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                //Here  i am assing value as property
                ShoppingCart = _shoppingCart,
                shoppingCartTotal = _shoppingCart.GetshoppingCartTotal() //what every is come from shoppingCartTotals
            };
            //here Iam not only returning shoppingCartViewModel Iam returng also  IViewComponentResult(it is specific typ)
            return View(shoppingCartViewModel);
        }
    }
}
