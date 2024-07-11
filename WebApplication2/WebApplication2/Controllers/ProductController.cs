using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }   
        [HttpPost]
        public IActionResult AddProduct(string title, string description, double unitPrice, string? imageUrl, int quantity)
        {
            Products products = new Products(title,description,unitPrice,imageUrl,quantity);
            productService.Insert(products);    
            return View();
        }
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            List<Products> product=productService.GetAll();
            ViewData["catalog"] = (product);
            return View();
        }
        [HttpGet]
        public IActionResult GetById()
        {
            return View();
        }
        [HttpPost]
        public IActionResult GetById(int id)
        {
            Products prod=productService.GetById(id);
            ViewData["catalog"]=(prod);
            return View();
        }
        [HttpGet]
        public IActionResult UpdateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(int id, string title, string description, double unitPrice, string? imageUrl, int quantity)
		{
			Products product = new Products(id, title, description, unitPrice, imageUrl, quantity);
			productService.Update(product);
			return RedirectToAction("Index", "Home");
		}
        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            productService.Delete(id);
            return RedirectToAction("Index", "Home");
        }
	}
}
