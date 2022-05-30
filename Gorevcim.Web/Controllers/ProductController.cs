using Gorevcim.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Gorevcim.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _productService.GetWebProductCategories();
            return View(result);
        }
    }
}
