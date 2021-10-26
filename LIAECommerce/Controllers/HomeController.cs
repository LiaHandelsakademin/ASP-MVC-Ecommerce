using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly LIAECommerceContext _context;
        public HomeController(LIAECommerceContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.OcProducts.Where(p => p.Points == 400).ToList();

            return View("Index", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }
       
    }
}
