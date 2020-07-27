using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Shop.Model;

namespace Shop.Controllers
{
    public class OneProductController : Controller
    {
        ShopContext db;
        public OneProductController(ShopContext context)
        {
            db = context;
        }
        public IActionResult OneProduct(int id)
        {
            return View(db.Products.Where(product => id == product.ProductId));
        }
    }
}