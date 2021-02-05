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

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice > 0)
            {
                _cars.Add(car);
            }
            else 
            {
                Console.WriteLine("Araba Adı iki karakterden fazla olmalıdır. Kiralama Ücreti Sıfır Olamaz.");
            }
            
        }

        public void Delete(Car car)
        {
            _cars.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _cars.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _cars.GetAll(p => p.BrandId == id);
        }

        public List<Car> GetCarsByBrandId()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _cars.GetAll(p => p.ColorId== id);
        }

        public List<Car> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _cars.Update(car);
        }
    }
}

