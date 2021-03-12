using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetCustomers();
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
    }
}
