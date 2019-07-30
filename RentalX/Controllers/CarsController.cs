using RentalX.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalX.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Cars
        public ActionResult Index()
        {
            var carsToView = _context.Cars.Include(c => c.Make).Include(c => c.CarClass).ToList();
            ViewData["PageTitle"] = "Cars";
            return View("Index", carsToView);
        }
    }
}