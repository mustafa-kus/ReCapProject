using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brand;
        List<Color> _color;
        List<tempClass> _templist;
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
            _brand = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Alfa Romeo"},
                new Brand{BrandId=2,BrandName= "Aston Martin" },
                new Brand{BrandId=3,BrandName= "Audi" },
                new Brand{BrandId=4,BrandName= "Bentley" },
                new Brand{BrandId=5,BrandName= "BMW" },
                new Brand{BrandId=6,BrandName= "Bugatti" },
                new Brand{BrandId=7,BrandName= "Buick" },
                new Brand{BrandId=8,BrandName= "Cadillac" }
            };
            _color = new List<Color>
            {
                new Color{ColorId=1, ColorName="Kırmızı"},
                new Color{ColorId=2, ColorName="Beyaz"},
                new Color{ColorId=3, ColorName="Sarı"},
                new Color{ColorId=4, ColorName="Siyah"}
            };


        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
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
