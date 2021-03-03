using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;

        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var reviewList = reviewRepo.GetAll();
            return View(reviewList);
        }
        public ViewResult Update(int id)
        {
            //var toppings = reviewRepo.PopulateToppingsList();

            //ViewBag.Toppings = new SelectList(toppings, "Id", "Name");

            var review = reviewRepo.GetById(id);

            return View(review);
        }

        [HttpPost]
        public ViewResult Update(Review model)
        {
            reviewRepo.Update(model);

            ViewBag.Result = "You have successfully updated this review";

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var review = reviewRepo.GetById(id);

            reviewRepo.Delete(review);

            return RedirectToAction("Index");
        }

    }
}
