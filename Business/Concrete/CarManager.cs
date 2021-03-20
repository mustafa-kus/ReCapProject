using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _cars;
        ICarImageService _carImageService;
        public CarManager(ICarDal carDal, ICarImageService carImageService)
        {
            _carImageService = carImageService;
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
            return new SuccessDataResult<List<CarDetailDto>>(_cars.GetCarsDetail());
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
        public IDataResult<CarDetailAndImagesDto> GetCarDetailAndImagesDto(int carId)
        {
            var result = _cars.GetCarDetail(carId);
            var imageResult = _carImageService.GetAllByCarId(carId);
            if (result == null || imageResult.Success == false)
            {
                return new ErrorDataResult<CarDetailAndImagesDto>(Messages.GetErrorCarMessage);
            }

            var carDetailAndImagesDto = new CarDetailAndImagesDto
            {
                Car = result,
                CarImages = imageResult.Data
            };

            return new SuccessDataResult<CarDetailAndImagesDto>(carDetailAndImagesDto, Messages.GetSuccessCarMessage);
        }




        public IDataResult<List<CarDetailDto>> GetCarsDetail()
        {
            List<CarDetailDto> carDetails = _cars.GetCarsDetail();
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.GetErrorCarMessage);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, Messages.GetErrorCarMessage);
            }
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailByBrandId(int brandId)
        {
            List<CarDetailDto> carDetails = _cars.GetCarsDetail(p => p.BrandId == brandId);
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.GetErrorCarMessage);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, Messages.GetErrorCarMessage);
            }
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailByBrandIdAndColorId(int brandId, int colorId)
        {
            List<CarDetailDto> carDetails = _cars.GetCarsDetail(p => p.BrandId == brandId && p.ColorId == colorId);
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.GetErrorCarMessage);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, Messages.GetErrorCarMessage);
            }
        }

        public IDataResult<List<CarDetailDto>> GetCarsDetailByColorId(int colorId)
        {
            List<CarDetailDto> carDetails = _cars.GetCarsDetail(p => p.ColorId == colorId);
            if (carDetails == null)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.GetErrorCarMessage);
            }
            else
            {
                return new SuccessDataResult<List<CarDetailDto>>(carDetails, Messages.GetErrorCarMessage);
            }
        }


    }
}

