using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (CheckCarNameLength(car))
            {
                if (CheckCarDailyPrice(car))
                {
                    _carDal.Add(car);
                }
                else
                {
                    Console.WriteLine("Araba eklenemedi! Arabanın günlük fiyatı 0 TL den büyük olmalıdır.");
                }
            }
            else
            {
                Console.WriteLine("Araba eklenemedi! Araba ismi en az 2 karakterden oluşmalıdır.");
            }
        }

        public bool CheckCarDailyPrice(Car car)
        {
            if (car.DailyPrice > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckCarNameLength(Car car)
        {
            if (car.Description.Length >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Car> GetCars()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll(car => car.BrandId == id);
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(car => car.ColorId == id);
        }
    }
}
