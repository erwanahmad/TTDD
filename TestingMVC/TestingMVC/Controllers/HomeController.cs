using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestingMVC.Models;

namespace TestingMVC.Controllers
{
    public class HomeController : Controller
    {
        private Repository repo;

        public HomeController(Repository input)
        {
            repo = input; // mockRepository
        }

        public HomeController()
        {
            repo = new FullRepository();
        }

        public ViewResult Index()
        {
            var books = repo.GetAll();
            return View(books);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ViewResult FindByGenre(string desiredGenre)
        {
            var books = repo.GetAll();
            var desiredBooks = books.Where(book => book.Genre == desiredGenre);
            return View(desiredBooks);
        }
    }
}