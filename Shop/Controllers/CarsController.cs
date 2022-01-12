using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars allCars;
        private readonly ICarsCategory carsCategory;

        public CarsController(IAllCars IAllCars, ICarsCategory ICarsCategory)
        {
            this.allCars = IAllCars;
            this.carsCategory = ICarsCategory; 
        }

        // https://localhost:44357/Cars/List
        /*public ViewResult List()
        {
            ViewBag.SomeViewBackCategory = "Some new text in view bag";
            var cars = allCars.Cars;
            return View(cars);
        }*/

        // https://localhost:44357/Cars/List
        public ViewResult List()
        {
            ViewBag.Title = "страница с автомобилем";
            CarsListViewModel obj = new CarsListViewModel();
            obj.AllCars = allCars.Cars;
            obj.CurrentCategory = "Все автомобили";
            return View(obj);
        }
    }
}
