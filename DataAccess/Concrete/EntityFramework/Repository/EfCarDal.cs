using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from color in context.Colors
                    join car in context.Cars on color.ColorId equals car.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carImage in context.CarImages on car.CarId equals  carImage.CarId
                    select new CarDetailDto()
                    {
                        CarId = car.CarId,
                        ImagePath = carImage.ImagePath,
                        Descriptions = car.Description,
                        BrandName = brand.BrandName,
                        CarImageDate = carImage.Date,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear
                    };
                return result.ToList();

            }
        }
    }
}
