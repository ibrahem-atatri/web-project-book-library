using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;

namespace BookLibrary.Controllers
{
    public class LogInController : Controller
    {
        private LibraryContext context { get; set; }

        public LogInController(LibraryContext ctx) => context = ctx;
        public IActionResult LogIn()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        public IActionResult Register()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("Register",new User());
        }

        [HttpPost]
        public IActionResult LogIn(string email ,string password)
        {
            User user = context.Users.FirstOrDefault(u => u.userEmail == email && u.userPassword == password);

            if (user == null)
            {
                string text = "your email or password is wrong";
                return View("LogIn",text);
            }

            // Set session
           HttpContext.Session.SetInt32("UserId", user.userId);
        HttpContext.Session.SetString("userAdmin", user.userAdmin.ToString());

            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Register(User user,String password)
        {


           
            
            context.Users.Add(user);
                context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", user.userId);
                HttpContext.Session.SetString("userAdmin", user.userName);

            return RedirectToAction("Index", "Home");
         


        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            return View("LogIn");


        }
    }
}
