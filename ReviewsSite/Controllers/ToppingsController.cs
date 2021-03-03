using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;


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

        public ViewResult Details(int id)
        {
            var toppings = toppingsRepo.GetById(id);

            return View(toppings);
        }

        public ViewResult Create()
        {

            return View(new Toppings());
        }

        [HttpPost]
        public ActionResult Create(Toppings model)
        {

            if (toppingsRepo.GetToppingsByName(model.Name) == null)
            {
                toppingsRepo.Create(model);
                ViewBag.Result = "You have successfully saved this topping.";
            }
            else
            {
                ViewBag.Error = "That topping already exists and cannot be added.";
            }

            ModelState.Clear();

            return View();
        }

        public ActionResult Delete(int id)
        {
            var toppings = toppingsRepo.GetById(id);

            toppingsRepo.Delete(toppings);

            return RedirectToAction("Index");
        }
    }
}
