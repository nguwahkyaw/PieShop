﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BethanyPieShop1.Models;
using BethanyPieShop1.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BethanyPieShop1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            
            var pies = _pieRepository.GetAllPies().OrderBy(x => x.Name);
            var homeViewModel = new HomeViewModel()
            {
                Title = "Welcome to my BethanyPieShop",
                Pies = pies.ToList()
            };

            return View(homeViewModel);
        }
    }
}
