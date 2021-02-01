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
                System.Console.WriteLine($"{car.Description} Üretim Yılı: {car.ModelYear} Fiyatı: {car.DailyPrice}");
            }
        }
    }
}
