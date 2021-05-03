using ECommerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var model = new AdminIndexViewModel
            {
                // Products = productRepo.GetAllProducts(),
                // TODO: ???
            };
            return View(model);
        }
    }
}
