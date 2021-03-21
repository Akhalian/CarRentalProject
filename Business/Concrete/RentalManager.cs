using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (rental.ReturnDate != DateTime.MinValue)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(RentalMessages.RentalAdded);
            }
            else
            {
                return new ErrorResult();
            }
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(RentalMessages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetRentals()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(),RentalMessages.RentalsListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(RentalMessages.RentalUpdated);
        }

        public IDataResult<List<Rental>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(rental=>rental.CarId==carId));
        }

        public IDataResult<List<RentDetailsDto>> GetRentDetails()
        {
            return new SuccessDataResult<List<RentDetailsDto>>(_rentalDal.GetRentDetails(), RentalMessages.GetRentDetails);
        }

        public IDataResult<List<RentDetailsDto>> GetRentDetailsByCarId(int carId)
        {
            return new SuccessDataResult<List<RentDetailsDto>>(
                _rentalDal.GetRentDetails(rentDetail => rentDetail.CarId == carId));
        }

        public IResult IsRentable(Rental rental)
        {
            var result = this.GetByCarId(rental.CarId).Data.LastOrDefault();
            if (IsDelivered(rental).Success || (rental.ReturnDate > result.ReturnDate && rental.RentDate >= DateTime.Now))
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

        public IResult IsDelivered(Rental rental)
        {
            var result = this.GetByCarId(rental.CarId).Data.LastOrDefault();
            if (result == null || result.ReturnDate != default)
                return new SuccessResult();
            return new ErrorResult();

        }
    }
}
