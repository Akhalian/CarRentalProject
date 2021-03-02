using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalDbContext>, ICarDal
    {
        public List<RentDetailsDto> getRentDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from color in context.Colors
                    join car in context.Cars on color.ColorId equals car.ColorId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    select new RentDetailsDto
                    {
                        CarName = car.Description,
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice
                    };
                return result.ToList();

            }
        }
    }
}
