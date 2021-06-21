using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using Zoomer.Models;
using Zoomer.ViewModels;

namespace Zoomer.Controllers
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
        public ViewResult Index()
        {
            var cars = _context.Cars.Include(c => c.BodyStyle).ToList();
            return View(cars);
        }
        public ActionResult New()
        {
            var bodyStyles = _context.BodyStyles.ToList();

            var viewModel = new NewCarViewModel
            {
                BodyStyles = bodyStyles
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Save(Car car)
        {
            if(car.Id == 0)
                _context.Cars.Add(car);
            else
            {
                var carInDb = _context.Cars.Single(c => c.Id == car.Id);
                carInDb.Make = car.Make;
                carInDb.Model = car.Model;
                carInDb.DateAdded = car.DateAdded;
                carInDb.YearOfMake = car.YearOfMake;
                carInDb.BodyStyleId = car.BodyStyleId;
               
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Cars");
        }
        public ActionResult Details(int id)
        {
            var car = _context.Cars.Include(c => c.BodyStyle).SingleOrDefault(c => c.Id == id);
            if (car == null)
                return HttpNotFound();
            return View(car);
        }
        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (car == null)
                return HttpNotFound();
            var viewModel = new NewCarViewModel
            {
                Car = car,
                BodyStyles = _context.BodyStyles.ToList()
            };
            return View("New", viewModel);
        }
    }
}