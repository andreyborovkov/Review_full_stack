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
        private ICategoryRepository categoryRepo;

        public HomeController(IReviewRepository reviewRepo, ICategoryRepository categoryRepo)
        {
            this.reviewRepo = reviewRepo;
            this.categoryRepo = categoryRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        public ViewResult Categories()
        {
            var model = categoryRepo.GetAll();
            return View(model);
        }

    }
}
