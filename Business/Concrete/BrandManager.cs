using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brand;
        public BrandManager(IBrandDal brandDal)
        {
            _brand= brandDal;
        }
        public void Add(Brand brand)
        {
            _brand.Add(brand);
        }

        public void Delete(Brand brand)
        {
            _brand.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            return _brand.GetAll();
        }

        public Brand GetById(int id)
        {
            return _brand.GetAll(b => b.BrandId == id)[0];
        }

        public void Update(Brand brand)
        {
            _brand.Update(brand);
        }
    }
}
