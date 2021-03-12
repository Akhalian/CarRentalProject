using System;
using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework.Repository
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, CarRentalDbContext>, ICustomerDal 
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (CarRentalDbContext context = new CarRentalDbContext())
            {
                var result = from customer in context.Customers
                    join user in context.Users on customer.UserId equals user.UserId
                    select new CustomerDetailDto()
                    {
                        CutomerId = customer.CustomerId,
                        UserId = user.UserId,
                        CustomerName = customer.CustomerName,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        Email = user.Email,
                        Status = user.Status
                    };
                return result.ToList();
            }
        }
    }
}
