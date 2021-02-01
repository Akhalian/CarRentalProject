using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllCars();
        List<Car> GetById(int id);
        List<Car> GetByBrandId(int brandId);
        List<Car> GetByPrice(decimal dailyPrice1, decimal dailyPrice2);
        List<Car> GetByYear(int modelYear1, int modelYear2);

    }
}
