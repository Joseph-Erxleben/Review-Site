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

        public ViewResult Create()
        {

            return View(new Review());
        }

        [HttpPost]

        public ViewResult Create(Review model)
        {
            reviewRepo.Create(model);

            ViewBag.Result = "You have successfully written your review.";

            return View(model);
        }

    }
}
