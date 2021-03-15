//using DataAccess.Abstract;
//using Entities.Concrete;
//using Entities.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Linq.Expressions;

//namespace DataAccess.Concrete.InMemory
//{
//    public class CarDal : ICarDal
//    {
//        List<Car> _car = new List<Car>()
//        {
//            new Car{CarId = 1, BrandId = 1, ColorId = 1, DailyPrice= 300, Description = "Beyaz Ford Focus", ModelYear=2014},
//            new Car{CarId = 2, BrandId = 2, ColorId = 2, DailyPrice= 350, Description = "Siyah Volkswagen Golf", ModelYear=2016},
//            new Car{CarId = 3, BrandId = 3, ColorId = 3, DailyPrice= 220, Description = "Kirmizi Fiat Linea", ModelYear=2019},
//            new Car{CarId = 4, BrandId = 4, ColorId = 4, DailyPrice= 250, Description = "Gri Renault Magane", ModelYear=2017},
//            new Car{CarId = 5, BrandId = 5, ColorId = 5, DailyPrice= 400, Description = "Yeşil Audi A3", ModelYear=2014}
//        };

//        public void Add(Car car)
//        {
//            _car.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _car.SingleOrDefault(c=> c.CarId == car.CarId);
//            _car.Remove(carToDelete);
//        }

//        public List<CarDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAllCars()
//        {
//            return _car;
//        }

//        public List<Car> GetByBrandId(int brandId)
//        {
//            return _car.Where(c => c.BrandId == brandId).ToList();
//        }

//        public List<Car> GetById(int id)
//        {
//            return _car.Where(c => c.CarId == id).ToList();
//        }

//        public List<Car> GetByPrice(decimal dailyPrice1, decimal dailyPrice2)
//        {
//            return _car.Where(c => dailyPrice1 < c.DailyPrice && c.DailyPrice < dailyPrice2).ToList();
//        }

//        public List<Car> GetByYear(int modelYear1, int modelYear2)
//        {
//            return _car.Where(c => modelYear1 < c.ModelYear && c.ModelYear < modelYear2).ToList();
//        }

//        public List<RentDetailsDto> getRentDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _car.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;
//        }

//        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
