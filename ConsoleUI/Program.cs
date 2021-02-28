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
            
            ////CarAdd();
            ////Kullanıcı Ekle
            //UserManager userManager = new UserManager(new EfUserDal());
            //User user1 = new User { FirstName="Mustafa", LastName="Kuş", Email="mustafa_kus@hotmail.com", Password="Yıl.2021" };
            //var result=userManager.Add(user1);
            //Console.WriteLine("User1 "+ result.Message);
            //User user2 = new User { FirstName = "Muzaffer", LastName = "Övün", Email = "muzafferovun@hotmail.com", Password = "MÖ.2021" };
            //result = userManager.Add(user2);
            //Console.WriteLine("User2 " + result.Message);
            //Müşteri Ekle
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //Customer customer1 = new Customer
            //{
            //    UserId = user1.Id,
            //    CompanyName = "M&F"
            //};
            //result= customerManager.Add(customer1);
            //Console.WriteLine("customer1 " + result.Message);
            //result=customerManager.Add(new Customer
            //{
            //    UserId = user2.Id,
            //    CompanyName = "Verim"
            //});
            //Console.WriteLine("customer2 " + result.Message);
            ////Araç Kirala
           
            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //Rental rental1 = new Rental { CarId = 1, CustomerId = 2, RentDate = Convert.ToDateTime("12.02.2021")};
            //result=rentalManager.Add(rental1);
            //Console.WriteLine("Araç Kiralama " + result.Message);
            ////Araç Kiralanamaz
            //result=rentalManager.Add(new Rental
            //{
            //    CarId = 1,
            //    CustomerId = 2,
            //    RentDate = Convert.ToDateTime("13.02.2021")
            //});
            //Console.WriteLine(result.Message);



        }

        private static void CarAdd()
        {
            //Araba Renkleri Ekleniyor
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color newColor1 = new Color { ColorName = "Kırmızı" };
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
            
            foreach (var car in carManager.GetAll().Data)
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

            foreach (var car in carManager.GetCarDetails().Data)
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
