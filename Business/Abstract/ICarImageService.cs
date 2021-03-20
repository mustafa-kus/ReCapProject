﻿using System;
using System.Collections.Generic;

using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetByCarId(int id);
        IDataResult<CarImage> Get(int id);
        IResult Add(IFormFile file, CarImage carImage);
        IResult Update(IFormFile file, CarImage carImage);
        IResult Delete(CarImage carImage);

        IResult Add2(CarImagesOperationDto carImagesOperationDto);

        IResult Update2(CarImagesOperationDto carImagesOperationDto);

        IResult Delete2(CarImage entity);

        IDataResult<List<CarImage>> GetAllByCarId(int carId);
    }
}
