using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();

        public IEnumerable<Car> Cars 
        { 
            get
            {
                return new List<Car>
                {
                    new Car  {Name = "Tesla", ShortDesc = "быстрый", LongDesc = "на электричесве", Img = "/img/Tesla.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = _categoryCars.AllCategories.First() },
                    new Car  {Name = "Ford Fiesta", ShortDesc = "Тихий и спокойный", LongDesc = "удобный тачка", Img = "/img/uaz_3909_1.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = _categoryCars.AllCategories.Last()},
                    new Car  {Name = "BWM", ShortDesc = "беха", LongDesc = "гонять как пидр", Img = "/img/bmw_4-series_gran_coupe_1.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = _categoryCars.AllCategories.Last()},
                    new Car  {Name = "Nissan leaf", ShortDesc = "тоже тролебус", LongDesc = "на электричесве как тесла", Img = "/img/astenmarter.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = _categoryCars.AllCategories.First() },
                };
            }
        }

        public IEnumerable<Car> getFavCars { get; set; }

        public Car GetObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
