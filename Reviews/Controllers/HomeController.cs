using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reviews.Controllers
{
    public class HomeController : Controller
    {
        private IReviewRepository reviewRepo;

        public HomeController(IReviewRepository dogRepo)
        {
            this.reviewRepo = dogRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.FindById(id);
            return View(model);
        }

    }
}
