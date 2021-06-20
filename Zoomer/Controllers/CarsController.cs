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


        }
        public ActionResult Details(int id)
        {
            var car = _context.Cars.Include(c => c.BodyStyle).SingleOrDefault(c => c.Id == id);
            if (car == null)
                return HttpNotFound();
            return View(car);
        }
    }
}