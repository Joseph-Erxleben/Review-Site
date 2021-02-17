using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ReviewsSite.Controllers
{
    public class ToppingsController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
