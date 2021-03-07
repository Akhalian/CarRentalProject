using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalDbContext>, IRentalDal
    {
        public List<RentDetailsDto> GetRentDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from rental in context.Rentals
                    join car in context.Cars on rental.CarId equals car.CarId
                    join brand in context.Brands on car.BrandId equals brand.BrandId
                    join color in context.Colors on car.ColorId equals color.ColorId
                    join customer in context.Customers on rental.CustomerId equals customer.CustomerId
                    select new RentDetailsDto()
                    {
                        BrandName = brand.BrandName,
                        ColorName = color.ColorName,
                        DailyPrice = car.DailyPrice,
                        CarName = car.Description,
                        RentDate = rental.RentDate,
                        ReturnDate = rental.ReturnDate,
                        CustomerName = customer.CustomerName
                    };
                return result.ToList();
            }
        }
    }
}
