using Business.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        CarDal _carDal;

        public CarManager(CarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetAllCars()
        {
            return _carDal.GetAllCars();
        }

        public List<Car> GetByBrandId(int brandId)
        {
            return _carDal.GetByBrandId(brandId);
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }

        public List<Car> GetByYear(int modelYear1 = 0 , int modelYear2 = 99999)
        {
            return _carDal.GetByYear(modelYear1,modelYear2);
        }

        public List<Car> GetByPrice(decimal dailyPrice1 = 0, decimal dailyPrice2 = 99999999999999)
        {
            return _carDal.GetByPrice(dailyPrice1, dailyPrice2);
        }
    }
}
