using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LIAECommerce.Controllers
{
    public class ProdCateController : Controller
    {
        private readonly LIAECommerceContext _context;
        public ProdCateController(LIAECommerceContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
