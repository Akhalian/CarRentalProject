using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new CarDal());

            System.Console.WriteLine("--------------GetAll-------------------");

            foreach (var car in carManager.GetAllCars())
            {
                System.Console.WriteLine($"{car.Description}\n Üretim Yılı: {car.ModelYear}\t Fiyatı: {car.DailyPrice}\n");
            }

            System.Console.WriteLine("--------------GetByPrice-------------------");

            foreach (var car in carManager.GetByPrice(150000,250000))
            {
                System.Console.WriteLine($"{car.Description}\n Üretim Yılı: {car.ModelYear}\t Fiyatı: {car.DailyPrice}\n");
            }
            System.Console.WriteLine("--------------GetByYear-------------------");

            foreach (var car in carManager.GetByYear(2010))
            {
                System.Console.WriteLine($"{car.Description}\n Üretim Yılı: {car.ModelYear}\t Fiyatı: {car.DailyPrice}\n");
            }
        }
    }
}
