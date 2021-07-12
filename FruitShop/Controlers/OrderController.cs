using FruitShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Controlers
{
    [Authorize]
    public class OrderController : Controller
    {
        
        private readonly IOrderRpository _orderRpository;
        private readonly ShoppingCart _shoppingCart;
      
        public OrderController(IOrderRpository orderRpository, ShoppingCart shoppingCart)
        {
            _orderRpository = orderRpository;
            _shoppingCart = shoppingCart;
        }
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            _shoppingCart.ShoppingCartItems = _shoppingCart.GetShoppingCartItems();
            if (_shoppingCart.ShoppingCartItems.Count==0)
            {
                ModelState.AddModelError("", "Your Cart is empty");
            }
            if (ModelState.IsValid)
            {
                _orderRpository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thank you for your orde. Enjoy your Fruit";
            return View();
        }
    }
}

