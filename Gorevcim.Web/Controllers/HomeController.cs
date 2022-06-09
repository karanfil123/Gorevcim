using Gorevcim.Core.Services;
using Gorevcim.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Gorevcim.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger,IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index()
        {
            ViewBag.totalProductCount = _productService.TotalProductCount().ToString();
            ViewBag.activeProductCount = _productService.WebActiveProductCount().ToString();
            ViewBag.nonActiveProductCount = _productService.WebNonActiveProductCount().ToString();
            return View();
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