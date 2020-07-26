using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers.Account
{
    public class AccountRegController : Controller
    {
        public IActionResult AccountReg()
        {
            return View();
        }
    }
}