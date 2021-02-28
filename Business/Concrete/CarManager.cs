using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cars;
        public CarManager(ICarDal carDal)
        {
            _cars = carDal;
        }
        [SecuredOperation("car.add,admin")]
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            //ValidationTool.Validate(new CarValidator(), car);
            _cars.Add(car);
            return new SuccessResult(Messages.AddedOK);
          

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

            return new SuccessDataResult<List<Car>>(_cars.GetAll());
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_cars.Get(c => c.Id == id));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.BrandId == id));
        }


        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_cars.GetAll(c => c.ColorId == id));
        }


        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_cars.GetAllCarDetail());
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

