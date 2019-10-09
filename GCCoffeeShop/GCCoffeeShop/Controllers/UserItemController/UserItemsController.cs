using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GCCoffeeShop.Models;
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
        public IActionResult ItemResults(UserItems userItem)
        {
            if (ModelState.IsValid)
            {
                return View(userItem);
            }
            else
            {
                return RedirectToAction("Error");
            }
            
        }
        public IActionResult Error()
        {
            return View();
        }
        
    }
}