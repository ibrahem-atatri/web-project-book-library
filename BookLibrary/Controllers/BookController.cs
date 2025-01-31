using BookLibrary.Models;
using Microsoft.AspNetCore.Components.RenderTree;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        private LibraryContext context { get; set; }

        public BookController(LibraryContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult Add()
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("LogIn", "LogIn");
            }
            if (HttpContext.Session.GetString("userAdmin") == "False")
            {
                return RedirectToAction("Index", "Home");
            }
         



            return View("AddBook",new Book());
        }

        [HttpPost] 
        public IActionResult Add(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult Edit(int id) {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("LogIn", "LogIn");
            }
            if (HttpContext.Session.GetString("userAdmin") == "False")
            {
                return RedirectToAction("Index", "Home");
            }
            Book book = context.Books.Find(id);
            return View("EditBook",book);
        }

        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Books.Update(book);
                context.SaveChanges();
            }
            return RedirectToAction("Index", "Home");


        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("LogIn", "LogIn");
            }
            if (HttpContext.Session.GetString("userAdmin") == "False")
            {
                return RedirectToAction("Index", "Home");
            }
            Book book = context.Books.Find(id);
            context.Books.Remove(book);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");
            
        }

    }
}
