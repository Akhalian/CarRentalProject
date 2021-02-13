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
            UserManager userManager = new UserManager(new EfUserDal());

            //carManager.Add(new Car() { CarId = 1, BrandId = 2, ColorId = 1, DailyPrice = 200, Description = "Focus", ModelYear = 2016 });
            //carManager.Add(new Car() { CarId = 2, BrandId = 2, ColorId = 2, DailyPrice = 250, Description = "Golf", ModelYear = 2016 });
            //carManager.Add(new Car() { CarId = 3, BrandId = 3, ColorId = 3, DailyPrice = 180, Description = "Linea", ModelYear = 2019 });
            //carManager.Add(new Car() { CarId = 4, BrandId = 4, ColorId = 4, DailyPrice = 240, Description = "Megane", ModelYear = 2017 });
            //carManager.Add(new Car() { CarId = 5, BrandId = 5, ColorId = 2, DailyPrice = 300, Description = "A3", ModelYear = 2014 });

            //brandManager.Add(new Brand() { BrandId = 1, BrandName = "Ford" });
            //brandManager.Add(new Brand() { BrandId = 2, BrandName = "Volkswagen" });
            //brandManager.Add(new Brand() { BrandId = 3, BrandName = "Fiat" });
            //brandManager.Add(new Brand() { BrandId = 4, BrandName = "Renault" });
            //brandManager.Add(new Brand() { BrandId = 5, BrandName = "Audi" });

            //colorManager.Add(new Color() { ColorId = 1, ColorName = "Beyaz" });
            //colorManager.Add(new Color() { ColorId = 2, ColorName = "Siyah" });
            //colorManager.Add(new Color() { ColorId = 3, ColorName = "Kırmızı" });
            //colorManager.Add(new Color() { ColorId = 4, ColorName = "Gri" });

            //userManager.Add(new User() { UserId = 1, Email = "burakbaskin07@gmail.com", FirstName = "Burak", LastName = "Baskın", Password = "12345" });

            //CarTest(carManager);
            //BrandTest(brandManager);
            //ColorTest(colorManager);
            //RentDetailTest(carManager);







        }

        private static void RentDetailTest(CarManager carManager)
        {
            var result = carManager.GetRentDetailsDto();
            foreach (var rentDetailsDto in result.Data)
            {
                Console.WriteLine(
                    $"Araç adı: {rentDetailsDto.BrandName} {rentDetailsDto.CarName} " +
                    $"Araç rengi: {rentDetailsDto.ColorName} " +
                    $"Günlük Fiyatı: {rentDetailsDto.DailyPrice}");
            }

            Console.WriteLine(result.Message);
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
