using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zoomer.Models;
using Zoomer.ViewModels;

namespace Zoomer.Controllers
{
    public class CarsController : Controller
    {
        // GET: Cars
        public ActionResult Home()
        {
            var car = new Car() { Make = "VW", Model = "Golf" };
            var customers = new List<Customer>
            {
                new Customer {Name="Customer A"},
                new Customer {Name="Customer B"}
            };
            var viewModel = new RandomCarViewModel() 
            { 
                Car = car,
                Customers = customers
            };

            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        } 
    }
}