using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using Core.Entities.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.DTOs;
using Microsoft.Extensions.Configuration;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //carManager.Update(new Car() { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 200, Description = "Focus", ModelYear = 2016 });
            //carManager.Add(new Car() { BrandId = 2, ColorId = 2, DailyPrice = 250, Description = "Golf", ModelYear = 2016 });
            //carManager.Add(new Car() { BrandId = 3, ColorId = 3, DailyPrice = 180, Description = "Linea", ModelYear = 2019 });
            //carManager.Add(new Car() { BrandId = 4, ColorId = 4, DailyPrice = 240, Description = "Megane", ModelYear = 2017 });
            //carManager.Add(new Car() { BrandId = 5, ColorId = 2, DailyPrice = 300, Description = "A3", ModelYear = 2014 });

            //brandManager.Add(new Brand() { BrandName = "Ford" });
            //brandManager.Add(new Brand() { BrandName = "Volkswagen" });
            //brandManager.Add(new Brand() { BrandName = "Fiat" });
            //brandManager.Add(new Brand() { BrandName = "Renault" });
            //brandManager.Add(new Brand() { BrandName = "Audi" });

            //colorManager.Add(new Color() { ColorName = "Beyaz" });
            //colorManager.Add(new Color() { ColorName = "Siyah" });
            //colorManager.Add(new Color() { ColorName = "Kırmızı" });
            //colorManager.Add(new Color() { ColorName = "Gri" });

            //CarTest(carManager);
            //BrandTest(brandManager);
            //ColorTest(colorManager);
            //UserTest(userManager);

        }

        private static void UserTest(UserManager userManager)
        {
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine(user);
            }
        }


        private static void ColorTest(ColorManager colorManager)
        {
            foreach (var color in colorManager.GetColors().Data)
            {
                Console.WriteLine(color.ColorName);
            }

            Console.WriteLine(colorManager.GetColors().Message);
        }

        private static void BrandTest(BrandManager brandManager)
        {
            foreach (var brand in brandManager.GetBrands().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest(CarManager carManager)
        {
            foreach (var car in carManager.GetCars().Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
