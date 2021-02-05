using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByBrandId();
        List<Car> GetCarsByColorId();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);

    }
}
