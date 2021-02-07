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
            
            //Araba Renkleri Ekleniyor
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color newColor1 = new Color {ColorName="Kırmızı"};
            colorManager.Add(newColor1);
            Color newColor2 = new Color { ColorName = "Siyah" };
            colorManager.Add(newColor2);
            Color newColor3 = new Color { ColorName = "Mavi" };
            colorManager.Add(newColor3);
            Color newColor4 = new Color { ColorName = "Gri" };
            colorManager.Add(newColor4);
            Color newColor5 = new Color { ColorName = "Beyaz" };
            colorManager.Add(newColor5);

            // Araba Markaları Ekleniyor
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand newBrand1 = new Brand { BrandName = "Opel" };
            brandManager.Add(newBrand1);
            Brand newBrand2 = new Brand { BrandName = "Suziki" };
            brandManager.Add(newBrand2);
            Brand newBrand3 = new Brand { BrandName = "Ford" };
            brandManager.Add(newBrand3);
            Brand newBrand4 = new Brand { BrandName = "Honda" };
            brandManager.Add(newBrand4);

            CarManager carManager = new CarManager(new EfCarDal());
            //showCars();
            showCars2();
            //Yeni Araba Ekle
            Car newCar = new Car { BrandId = 1, ColorId = 1, DailyPrice = 10, ModelYear = 2000, Description = "Fiat" };
            //Araba Güncelle
            
            Car updateCar = new Car { Id = 2, BrandId = 1, ColorId = 3, DailyPrice = 500, ModelYear = 2020, Description = "Honda" };
            //Araba sil
            Car deleteCar = new Car { Id = 1, BrandId = 1, ColorId = 1, DailyPrice = 10, ModelYear = 2000, Description = "Fiat" };

            carManager.Update(updateCar);
            showCars2();

            
           
           


        }

        private static void showCars()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("{0}:{1}:{2}:{3}:{4}:{5}",
                    car.Id,
                    car.BrandId,
                    car.ColorId,
                    car.ModelYear,
                    car.DailyPrice,
                    car.Description
                    );
            }
        }
        private static void showCars2()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetAllCarDetails())
            {
                Console.WriteLine("{0}:{1}:{2}:{3}",
                    car.CarName,
                    car.BrandName,
                    car.ColorName,
                    car.DailyPrice
                    );
            }
        }
    }
}
