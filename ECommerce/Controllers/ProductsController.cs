using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ECommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ECommerce.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            var products = new[]{
                new Product
                {
                    Id = 1,
                    Name = "Easter Pillow Cover",
                    Description = "Burlap 18 X 18 pillow cover with Easter motif",
                    Price = 25.25m,
                    OnSale = true,
                },
                new Product
                {
                    Id = 2,
                    Name = "Summer Pillow Cover",
                    Description = "Burlap 18 X 18 pillow cover with Summer Flowers motif",
                    Price = 15.75m,
                    OnSale = true,
                },

                new Product
                {
                    Id = 3,
                    Name = "Throw Blanket",
                    Description = "Yellow 100% Cotton 50\" x 60\" throw blanket",

                },

                new Product
                {
                    Id = 4,
                    Name = "Down Alternative Bed Pillow",
                    Description = "Standard size machine washable medium firm down alternative pillow",

                },
            };
            return View(products);
        }

        // GET: Products/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Products/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Products/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Products/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
