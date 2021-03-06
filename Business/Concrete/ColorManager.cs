﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _color;
        public ColorManager(IColorDal colorDal)
        {
            _color = colorDal;
        }
        public IResult Add(Color color)
        {
            try
            {
                _color.Add(color);
                return new SuccessResult(Messages.AddedOK);
            }
            catch
            {
                return new ErrorResult(Messages.AddedErr);
            }
        }

        public IResult Delete(Color color)
        {
           
            try
            {
                _color.Delete(color);
                return new SuccessResult(Messages.DeletedOK);
            }
            catch
            {
                return new ErrorResult(Messages.DeletedErr);
            }
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>>( _color.GetAll());
        }

        public IDataResult< Color> GetById(int id)
        {
            return new SuccessDataResult<Color>( _color.Get(c => c.ColorId == id));
        }

        public IResult Update(Color color)
        {
            
            try
            {
                _color.Update(color);
                return new SuccessResult(Messages.UpdatedOK);
            }
            catch
            {
                return new ErrorResult(Messages.UpdatedErr);
            }
        }
    }
}
