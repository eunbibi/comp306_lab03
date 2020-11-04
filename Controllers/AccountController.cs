using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp_Rds_Access.Models;

namespace WebApp_Rds_Access.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
      /*  [AllowAnonymous]
        public ViewResult Login1Async(string returnUrl)
        {
            return View("Index", "Home");
            *//*return View(new LoginViewModel
            {
               // ReturnUrl = returnUrl
            });*//*
        }*/

        private readonly LearningContext _context;
        public AccountController(LearningContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Students.ToListAsync());
            //return View();
        }
        /*public async Task<IActionResult> Register()
        {

            return View(await _context.Students.ToListAsync());
            //return View();
        }*/

        /* [HttpPost]
         public IActionResult Register(Students std)
         {
             if (ModelState.IsValid)
             {
                 using (var db = new LearningContext())
                 {
                     db.Students.Add(std);
                     db.SaveChanges();
                 }
                 return RedirectToAction("Account", "Register");
             }
             return View(std);
         }*/

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register([Bind("StudentID,FirstName,LastName,Email,StudentPW")] Students students)
        {
            if (ModelState.IsValid)
            {
                 _context.Add(students);
                 await _context.SaveChangesAsync();
                   return RedirectToAction(nameof(Index));
                //    return RedirectToAction(nameof(students));
                // return View("../Student/Students");

                //return View(await _context.Students.ToListAsync());
            }
            return View(students);
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

                using (var db = new LearningContext()) 
                {
                    var user = _context.Students.FirstOrDefault(u => u.Email.Equals(model.Email) && u.StudentPW.Equals(model.StudentPW));
                    if (user != null)
                    {
                        
                        return RedirectToAction("Students","Student");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Email Address or password is wrong.");
                        return RedirectToAction("Index","Home");
                    }
                }
            }
            return View();
        }
    }
}
