using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brand;
        public BrandManager(IBrandDal brandDal)
        {
            _brand = brandDal;
        }
        public IResult Add(Brand brand)
        {
            try
            {
                _brand.Add(brand);
                return new SuccessResult(Messages.AddedOK);
            }
            catch
            {
                return new ErrorResult(Messages.AddedErr);
            }
        }

        public IResult Delete(Brand brand)
        {
            try
            {
                _brand.Delete(brand);
                return new SuccessResult(Messages.DeletedOK);
            }
            catch
            {
                return new ErrorResult(Messages.DeletedErr);
            }
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brand.GetAll(), Messages.ListedOK);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_brand.Get(b => b.BrandId == id));
        }

        public IResult Update(Brand brand)
        {
            try
            {
                _brand.Update(brand);
                return new SuccessResult(Messages.UpdatedOK);
            }
            catch
            {
                return new ErrorResult(Messages.UpdatedErr);
            }
        }
    }
}
