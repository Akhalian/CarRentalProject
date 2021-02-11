using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length>2)
            {
                if (car.DailyPrice > 0)
                {
                    _carDal.Add(car);
                    return new SuccesResult(Messages.CarAdded);
                }
                else
                {
                    return new ErrorResult(Messages.CarDailyPriceInvalid);
                }
            }
            else
            {
                return new ErrorResult(Messages.CarNameInvalid);
            }
        }

        public IDataResult<List<Car>> GetCars()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.BrandId == id),Messages.CarsListedByBrandId);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.ColorId == id),Messages.CarsListedByColorId);
        }

        public IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(car => car.DailyPrice >= min && car.DailyPrice <= max), Messages.CarsListedByDailyPrice);
        }
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccesResult(Messages.CarDeleted);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new ErrorResult(Messages.CarUpdated);
        }

        public IDataResult<List<RentDetailsDto>> GetRentDetailsDto()
        {
            return new SuccessDataResult<List<RentDetailsDto>>(_carDal.getRentDetails(), Messages.CarsRentDetailsDto);
        }
    }
}
