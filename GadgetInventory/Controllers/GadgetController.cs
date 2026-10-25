using Microsoft.AspNetCore.Mvc;
using GadgetInventory.Models;
using System.Collections.Generic;

namespace GadgetInventory.Controllers
{
    public class GadgetController : Controller
    {
        private static List<Gadget> gadgets = new List<Gadget>
        {
            new Gadget { Id = 1, Brand = "Apple", Model = "iPhone 13", Price = 999.99m },
            new Gadget { Id = 2, Brand = "Samsung", Model = "Galaxy S21", Price = 799.99m }
        };


        public IActionResult Index()
        {
            return View(gadgets);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Gadget newgadget)
        {
            if (!ModelState.IsValid)
            {
                return View(newgadget);
            }
            newgadget.Id = gadgets.Count + 1;
            gadgets.Add(newgadget);
            return RedirectToAction("Index");
        }
    }
}