using FruitShop.Models;
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
            return View(_fruitRepository.GetAllFruits);
        }
    }
}
