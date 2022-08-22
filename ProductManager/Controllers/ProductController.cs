using Microsoft.AspNetCore.Mvc;
using ProductManager.Models;

namespace ProductManager.Controllers
{
    public class ProductController : Controller
    {
        public List<Product> Products { get; set; }

        public ProductController()
        {
            Products = new List<Product>(){
                new Product { Id = 1, Name = "Product 1", Price = 100, Quantity = 10 },
                new Product { Id = 2, Name = "Product 2", Price = 200, Quantity = 20 },
                new Product { Id = 3, Name = "Product 3", Price = 300, Quantity = 30 },
            };
            
        }
        public IActionResult Index()
        {
            
            return View(Products);
        }
    }
}

