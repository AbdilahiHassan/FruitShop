using FruitShop.Models;
using FruitShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.Controlers
{
    public class FruitController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IFruitRepository _fruitRepository;

        public FruitController(ICategoryRepository categoryRepository, IFruitRepository fruitRepository)
        {
            _categoryRepository = categoryRepository;
             _fruitRepository = fruitRepository;

        }
        public IActionResult List()
        {
            //  ViewBag.CurrentCategory ="BestSeller";
            //return View(_fruitRepository.GetAllFruits);
            var fruitListVeiwModel = new FruitListVeiwModel();
            fruitListVeiwModel.Fruities = _fruitRepository.GetAllFruits;
            fruitListVeiwModel.CurrentCategory = "Best Saler";
            return View(fruitListVeiwModel);
        }
    }
}
