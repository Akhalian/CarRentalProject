using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        bool CheckCarNameLength(Car car);
        bool CheckCarDailyPrice(Car car);
        void Add(Car car);

    }
}
