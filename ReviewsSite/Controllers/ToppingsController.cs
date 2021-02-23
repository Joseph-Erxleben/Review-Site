using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ReviewsSite.Models;
using ReviewsSite.Repositories;


namespace ReviewsSite.Controllers
{
    public class ToppingsController : Controller
    {
        IRepository<Toppings> toppingsRepo;

        public ToppingsController(IRepository<Toppings> toppingsRepo)
        {
            this.toppingsRepo = toppingsRepo;
        }
        public ViewResult Index()
        {
            var toppingsList = toppingsRepo.GetAll();

            return View(toppingsList);
        }
    }
}
