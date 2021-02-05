using System;
using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal() );
            //YENİ ARABA EKLEME
            carManager.Add(new Car { Id = 2, BrandId = 1, ColorId = 1, DailyPrice=10, ModelYear=2000, Description="Fiat" });
            //Hata mesajı
            carManager.Add(new Car { Id = 3, BrandId = 2, ColorId = 3, DailyPrice = 0, ModelYear = 2000, Description = "Suziki" });

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }

        }
    }
}
