using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Views.Basket
{
    public class BasketController : Controller
    {
        public IActionResult Basket()
        {
            return View();
        }
    }
}