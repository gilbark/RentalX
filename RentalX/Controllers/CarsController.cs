using RentalX.Models;
using RentalX.ViewModels;
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

        public ViewResult New()
        {
            ViewData["PageTitle"] = "Add a new car";

            var viewModel = new CarFormViewModel
            {
                Classes = _context.CarClasses.ToList(),
                Make = _context.CarMakes.ToList()
            };
            return View("CarForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            ViewData["PageTitle"] = "Edit Car";

            var car = _context.Cars.SingleOrDefault(c => c.Id == id);

            if (car == null)
                return HttpNotFound();

            var viewModel = new CarFormViewModel(car)
            {
                Classes = _context.CarClasses.ToList(),
                Make = _context.CarMakes.ToList()
            };

            return View("CarForm", viewModel);
        }


        [HttpPost]
        public ActionResult Save(Car car)
        {
            var viewModel = new CarFormViewModel(car)
            {
                Classes = _context.CarClasses.ToList(),
                Make = _context.CarMakes.ToList()
            };
            if (!ModelState.IsValid)
            {
                return View("New", viewModel);
            }
            if (car.Id == 0)
            {
                _context.Cars.Add(car);
            }
            else
            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);
                carInDb.CarModel = car.CarModel;
                carInDb.MakeId = car.MakeId;
                carInDb.ClassId = car.ClassId;
                carInDb.CarMileage = car.CarMileage;
                carInDb.CostPerDay = car.CostPerDay;
                
            }

            _context.SaveChanges();
            return RedirectToAction("Index", "Cars");
        }
    }
}