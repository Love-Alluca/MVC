using Microsoft.AspNetCore.Mvc; //get a library
using MyMvcApp.Models;  //adapt the model to the controller

namespace MyMvcApp.Controllers
{
    public class ProductController : Controller //inheritance
    {
        // GET: Product
        public IActionResult Details()
        {
            // Create a list of products
            var products = new ProductModel()
            {
                Id = 1,
                Name = "Mechanical Keyboard",
                Price = 89.0m
            };

            // Pass the list of products to the view
            return View(products); //return the specific destination to merge with the html layout
        }
    }
}