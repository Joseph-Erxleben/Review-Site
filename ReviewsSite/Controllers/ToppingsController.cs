using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ReviewsSite.Models;


namespace ReviewsSite.Controllers
{
    public class ToppingsController : Controller
    {
        public ViewResult Index()
        {
            Toppings toppings = new Toppings();

            return View(toppings);
        }
    }
}
