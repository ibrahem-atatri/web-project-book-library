using System.Diagnostics;
using BookLibrary.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace BookLibrary.Controllers
{
    public class HomeController : Controller
    {
        private LibraryContext context { get; set; }

        public HomeController(LibraryContext ctx) => context = ctx;
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("LogIn", "LogIn");
            }
            if (HttpContext.Session.GetString("userAdmin") == "True")
            {
                ViewBag.admin = true;
            }
            else
            {
                ViewBag.admin = false;

            }
            var books = context.Books.ToList();
            return View(books);
        }

        public IActionResult About()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("LogIn", "LogIn");
            }
            return View();
        }
        [HttpPost]
        public IActionResult Search(string text)
        {
           
            var searchResults = context.Books.Where(b => b.bookName.Contains(text)).ToList();

            return View("Index", searchResults);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
