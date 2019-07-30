using RentalX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalX.Controllers
{
    public class CustomersController : Controller
    {
        ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers  <-- not in use yet
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult SignUp()
        {
            ViewData["PageTitle"] = "Sign Up";

            return View();
        }

        public ActionResult SaveNewCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            Console.WriteLine("User successfuly saved");
            return RedirectToAction("Index", "Home");
        }
    }
}