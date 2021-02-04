using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            carManager.Add(new Car(){ CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 300, Description = "Beyaz Ford Focus", ModelYear = 2014 });
            carManager.Add(new Car() { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 350, Description = "Siyah Volkswagen Golf", ModelYear = 2016 });
            carManager.Add(new Car() { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 200, Description = "Kırmızı Fiat Linea", ModelYear = 2019 });
            carManager.Add(new Car() { CarId = 4, BrandId = 4, ColorId = 4, DailyPrice = 250, Description = "Gri Renault Magane", ModelYear = 2017 });
            carManager.Add(new Car() { CarId = 5, BrandId = 5, ColorId = 2, DailyPrice = 400, Description = "Siyah Audi A3", ModelYear = 2014 });

            Console.WriteLine("-------------------BrandId-------------------");

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                Console.WriteLine($"Aradığınız markadaki arabalar : {car.Description}");
            }

            Console.WriteLine("-------------------ColorId-------------------");

            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine($"Aradığınız renkteki arabalar : {car.Description}");
            }

            Console.WriteLine("-------------------All-------------------");

            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
