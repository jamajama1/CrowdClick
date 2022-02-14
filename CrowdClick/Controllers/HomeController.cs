using ApplicationCore.ServiceInterfaces;
using CrowdClick.Models;
using Infrastucture.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CrowdClick.Controllers
{
    public class HomeController : Controller
    {
        private readonly IScraperService _scraperService;
        private readonly IProductService _productService;

        public HomeController(IScraperService scraperService, IProductService productService)
        {
            _scraperService = scraperService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {

            var products = await _productService.GetProducts();
            var url = "https://corner-123.com/bestsellers/";
            //var products = await _scraperService.GetProductDetails(url);
            // strongly type model to pass in data from controller
            return View(products);
        }

        public async Task<IActionResult> ProductDetails()
        {

            var products = await _productService.GetProductByName("Baby Pink Crop Top ", 1, (decimal)4.99);
            //var url = "https://corner-123.com/bestsellers/";
            //await _scraperService.GetProductDetails(url);
            // strongly type model to pass in data from controller
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
