using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=100, ModelYear=2000, Description="Fiyat 4 Kapılı"},
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=100, ModelYear=2005, Description="Ford Connect 2 Kapılı"},
                new Car{Id=3, BrandId=1, ColorId=3, DailyPrice=100, ModelYear=2015, Description="Nissan 4 Kapılı"},
                new Car{Id=4, BrandId=2, ColorId=1, DailyPrice=100, ModelYear=2020, Description="Anadol Kapılı"},
                new Car{Id=5, BrandId=3, ColorId=2, DailyPrice=100, ModelYear=2019, Description="Tesla Elktrikli"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete=null;
            carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
