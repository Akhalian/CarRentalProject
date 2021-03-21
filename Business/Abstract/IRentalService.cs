using Core.Utilities.Results.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetRentals();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        IDataResult<List<Rental>> GetByCarId(int carId);
        IDataResult<List<RentDetailsDto>> GetRentDetails();
        IDataResult<List<RentDetailsDto>> GetRentDetailsByCarId(int carId);
        IResult IsRentable(Rental rental);
    }
}
