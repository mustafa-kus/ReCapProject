using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{ 
    public class CarManager : ICarService
    {
        ICarDal _cars;
        public CarManager(ICarDal carDal)
        {
            _cars = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _cars.Add(car);
                return new SuccessResult(Messages.AddedOK);
            }
            else 
            {
                return new ErrorResult("Araba Adı iki karakterden fazla olmalıdır. Kiralama Ücreti Sıfır Olamaz.");
            }
            
        }

        public IResult Delete(Car car)
        {   
            try
            {
                _cars.Delete(car);
                return new SuccessResult(Messages.DeletedOK);
            }
            catch
            {
                return new ErrorResult(Messages.DeletedErr);
            }
        }

        public IDataResult<List<Car>> GetAll()
        {
            
            return new SuccessDataResult<List<Car>>( _cars.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_cars.Get(c => c.Id == id));
        }

        public IDataResult< List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>( _cars.GetAll(c => c.BrandId == id));
        }

        
        public IDataResult< List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.ColorId== id));
        }

       
        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _cars.GetAllCarDetail());
        }

        public IResult Update(Car car)
        {
            try
            {
                _cars.Update(car);
                return new SuccessResult(Messages.UpdatedOK);
            }
            catch
            {
                return new ErrorResult(Messages.UpdatedErr);
            }

        }

       
    }
}

