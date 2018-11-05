using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreDemo.Base;
using EFCoreDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers
{
    public class UserController : BaseController
    {
        public UserController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Users.ToList());
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(User registeruser)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(registeruser);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registeruser);
        }

        public IActionResult UserDetail(int Id)
        {
            var user = _context.Users.SingleOrDefault(m => m.Id==Id);
            if (user != null)
            {
                //user.
                //_context.UpdateRange(user);
            }
            return View(user);
        }
    }
}