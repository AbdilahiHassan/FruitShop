using FruitShop.Models;
using FruitShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Controlers
{
    public class HomeController : Controller
    {
        private readonly IFruitRepository _fruitRepository;
        public HomeController(IFruitRepository fruitRepository)
        {
            _fruitRepository = fruitRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
               FruitOnSale = _fruitRepository.GetFruitOnsale
        };
            return View(homeViewModel);
        }
    }
}
