using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Model;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        ShopContext db;
        public ProductController(ShopContext context)
        {
            db = context;
        }

        public IActionResult Product()
        {
            return View(db.Products.ToList());
        }
    }
}