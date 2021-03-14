using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from car in context.Cars
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join carImage in context.CarImages on car.CarId equals carImage.CarId 
                    select new CarDetailDto()
                    {
                        CarId = car.CarId,
                        ImagePath = carImage.ImagePath,
                        Description = car.Description,
                        BrandId = brand.BrandId,
                        BrandName = brand.BrandName,
                        CarImageDate = carImage.Date,
                        ColorId = color.ColorId,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        ModelYear = car.ModelYear
                    };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }
    }
}
