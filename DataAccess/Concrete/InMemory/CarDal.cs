using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class CarDal : ICarDal
    {
        List<Car> _cars = new List<Car>()
        {
            new Car{Id = 1, BrandId = 1, ColorId = 1, DailyPrice= 110000, Description = "EMSALSİZ!!! BOYASIZ EKSİKSİZ DOĞAN", ModelYear=2000},
            new Car{Id = 2, BrandId = 2, ColorId = 2, DailyPrice= 178000, Description = "ÇOK SEVDİĞİM ARABAMI BEDELLİ İÇİN SATIYORUM! TEMİZ ŞİROKKO", ModelYear=2014},
            new Car{Id = 3, BrandId = 3, ColorId = 3, DailyPrice= 224000, Description = "DOKTORDAN AZ VE TEMİZ KULLANILMIŞ MEGANE", ModelYear=2017},
            new Car{Id = 4, BrandId = 4, ColorId = 4, DailyPrice= 140000, Description = "2011 FORD FOCUS BOYA TAKINTISI OLAN ARAMASIN KEYFİ BOYALIDIR", ModelYear=2011},
            new Car{Id = 5, BrandId = 5, ColorId = 5, DailyPrice= 70000, Description = "2008 DOBLO HATASIZ BOYASIZ AİLE ARABASIDIR SERSERİYE GİTMEZ", ModelYear=2008}
        };

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAllCars()
        {
            return _cars;
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<Car> GetByPrice(decimal dailyPrice1, decimal dailyPrice2)
        {
            return _cars.Where(c => dailyPrice1 < c.DailyPrice && c.DailyPrice < dailyPrice2).ToList();
        }

        public List<Car> GetByYear(int modelYear1, int modelYear2)
        {
            return _cars.Where(c => modelYear1 < c.ModelYear && c.ModelYear < modelYear2).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
