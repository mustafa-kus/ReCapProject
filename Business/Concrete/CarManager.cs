using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{ 
    public class CarManager : ICarService
    {
        ICarDal _cars;
        public CarManager(ICarDal carDal)
        {
            _cars = carDal;
        }
        public List<Car> GetAll()
        {
            return _cars.GetAll();
        }
    }
}

