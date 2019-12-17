using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TicketManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace TicketManagementSystem.Controllers
{
    public class LogInController : Controller
    {
            private readonly AppDbContext _context;

            public LogInController(AppDbContext context)
            {
                _context = context;
            }

 
            public IActionResult Index()
            {
            return View();
            }


            public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return RedirectToAction("About", "Home");
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return RedirectToAction("Contact", "Home");
        }

        public IActionResult Error()
        {
            return View();
        }

        public ActionResult Registation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registation(Registation registation)
        {
            if (ModelState.IsValid)
            {
                _context.Registations.Add(registation);
                _context.SaveChanges();

                ModelState.Clear();
                ViewBag.Message = registation.Name + " " + registation.Email + " is successfully registered.";
            }
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(Registation registation)
        {
            var account = _context.Registations.Where(u => u.Name == registation.Name && u.Password == registation.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("U_Id", account.U_Id.ToString());
                HttpContext.Session.SetString("Name", account.Name);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "Username or password is wrong.");
            }
            return View();
        }

        public ActionResult Welcome()
        {
            if (HttpContext.Session.GetString("U_Id") != null)
            {
                ViewBag.Name = HttpContext.Session.GetString("Name");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult LogOut()
        { 
            HttpContext.Session.Clear();
             return RedirectToAction("Index","Home");
        }
    }
}
