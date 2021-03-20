using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int id);
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<CarDetailDto>> GetCarsDetail();
        IDataResult<List<CarDetailDto>> GetCarsDetailByBrandId(int brandId);
        IDataResult<List<CarDetailDto>> GetCarsDetailByColorId(int colorId);
        IDataResult<List<CarDetailDto>> GetCarsDetailByBrandIdAndColorId(int brandId, int colorId);
        IDataResult<CarDetailAndImagesDto> GetCarDetailAndImagesDto(int carId);

    }
}
