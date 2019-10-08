using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GCCoffeeShop.Controllers.UserItemController
{
    public class UserItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserItemsView()
        {
            return View();
        }
    }
}