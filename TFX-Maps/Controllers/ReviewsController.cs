using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TFX_Maps.Controllers
{
    public class ReviewsController : Controller
    {
        // GET: Reviews
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Top10()
        {
            var r = new Random();
            ViewBag.Reviews = new[] { this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r), this.GenerateReview(r) }
                .OrderByDescending(v => v.Score)
                .ToArray();
            return View();
        }

        public ActionResult View(Guid id)
        {
            ViewBag.Review = this.GenerateReview(new Random());
            return View();
        }

        private Models.ReviewModel GenerateReview(Random r)
        {
            return new Models.ReviewModel
            {
                Name = "Random Map",
                Author = "Ted",
                AuthorEmail = "ted@example.org",
                Score = r.Next(100),
                UserRating = r.NextDouble() * 5,
                UserVotes = r.Next(10),
                Architecture = r.Next(100),
                Layout = r.Next(100),
                Funness = r.Next(100),
                Originality = r.Next(100),
                Balance = r.Next(100),
                Review = "This is a good map",
                Reviewer = "Prof. Wimbleton"
            };
        }

    }
}