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
            Toppings toppings = new Toppings(57, "Pepperoni", "Pepperoni is an American variety of salami, made from cured pork and beef seasoned with paprika or other chili pepper.", false, "I like pepperoni. It is tasty and good.");

            return View(toppings);
        }
    }
}
