using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        //public static void Initial(IApplicationBuilder app)
        public static void Initial(AppDBContent content)
        {
            /*
            AppDBContent content;
            using (var scope = app.ApplicationServices.CreateScope())
            {
                content = scope.ServiceProvider.GetRequiredService<AppDBContent>();
            }
            */

            //AppDBContent content = app.ApplicationServices.GetRequiredService<AppDBContent>();

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car { Name = "Tesla", ShortDesc = "быстрый", LongDesc = "на электричесве", Img = "/img/Tesla.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = Categories["Электромобили"]  },
                    new Car { Name = "Ford Fiesta", ShortDesc = "Тихий и спокойный", LongDesc = "удобный тачка", Img = "/img/uaz_3909_1.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "BWM", ShortDesc = "беха", LongDesc = "гонять как пидр", Img = "/img/bmw_4-series_gran_coupe_1.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = Categories["Классические автомобили"] },
                    new Car { Name = "Nissan leaf", ShortDesc = "тоже тролебус", LongDesc = "на электричесве как тесла", Img = "/img/astenmarter.jpg", Price = 45000, IsFavourity = true, Avaliable = true, Category = Categories["Электромобили"] }
                    );
            }

            content.SaveChanges();

        }

        private static Dictionary<string, Category> category;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                    new Category { CategoryName = "Электромобили", Desc = "Современный вид трастпорта" },
                    new Category { CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего сгорания" }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                    {
                        category.Add(el.CategoryName, el);
                    }

                }
                return category;
            }

        }
    }
}
