using Microsoft.AspNetCore.Mvc;
using WebAppOnlineMart.Models;

namespace WebAppOnlineMart.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            var products = ProductsRepository.GetProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductsRepository.GetProductById(id);
            return View(product);
        }
    }
}

