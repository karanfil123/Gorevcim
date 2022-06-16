using Gorevcim.Core.Services;
using Gorevcim.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Dynamic;

namespace Gorevcim.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryServive;

        public HomeController(IProductService productService, ICategoryService categoryServive)
        {
            _productService = productService;
            _categoryServive = categoryServive;
        }
        //[Authorize]
        public async Task<IActionResult> Index()
        {
            dynamic myModel = new ExpandoObject();
            var products = await _productService.GetAllWebProductCategories();
            var categories = await _categoryServive.GetAllWebCategoriesProductsAsync();
            myModel._product = products;
            myModel._category = categories;
            myModel._productCount = products.Count();
            myModel._activeProductCount = products.Where(x => x.IsActive == true).Count();
            myModel._passiveProductCount = products.Where(x => x.IsActive == false).Count();
            myModel._categoryCount = categories.Where(x => x.IsActive == false).Count();
            return View(myModel);
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
    }
}