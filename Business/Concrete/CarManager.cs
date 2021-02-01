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

        public List<Car> GetById(int id)
        {
            return _carDal.GetById(id);
        }
    }
}
