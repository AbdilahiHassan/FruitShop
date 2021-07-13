using FruitShop.Models;
using FruitShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Controlers
{
    public class ShoppingCartController : Controller
    {
        private readonly IFruitRepository _fruitRepository;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IFruitRepository fruitRepository, ShoppingCart shoppingCart)
        {
            _fruitRepository = fruitRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Index()
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                shoppingCartTotal = _shoppingCart.GetshoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }
        public RedirectToActionResult AddToshoppingCar(int fruitid)
        {
            var selectFruit = _fruitRepository.GetAllFruits.FirstOrDefault(c => c.FruitId == fruitid);
            if (selectFruit != null)
            {
                _shoppingCart.AddToCart(selectFruit, 1); // Selectedfruit and ,Adding one Fruit at the time
            }
            return RedirectToAction("index");
        }

        public RedirectToActionResult RemoveFromshoppingCar(int fruitid)
        {
            var selectFruit = _fruitRepository.GetAllFruits.FirstOrDefault(c => c.FruitId == fruitid);
            if (selectFruit != null)//check if fruit excist
            {
                _shoppingCart.RemoveFromCart(selectFruit); //if excist i am removing from the cart
            }
            return RedirectToAction("index");
        }
        public RedirectToActionResult ClearCart()
        {
            _shoppingCart.ClearCart();
            return RedirectToAction("Index");
        }
    }
}
