using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            CarsManager carsManager = new CarsManager(new EfCarDal());
            var result1 = carsManager.GetAll();
            foreach (var item in result1.Data)
            {
                Console.WriteLine(item.Description);
            }

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //var result = customerManager.GetCustomerDetails();
            //foreach (var item in result.Data)
            //{
            //    Console.WriteLine(item.firstname+item.lastname+item.email+item.companyname);
            //}

            //RentalManager rentalManager = new RentalManager(new EfRentalDal());
            //var result = rentalManager.Add(new Rental { Id = 3, CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 2, 12), ReturnDate = new DateTime(2021, 3, 21) });
            //result = rentalManager.Add(new Rental { Id = 4, CarId = 3, CustomerId = 3, RentDate = new DateTime(2021, 3, 12), ReturnDate = new DateTime(2021, 3, 21) });
            //result = rentalManager.Add(new Rental { Id = 5, CarId = 4, CustomerId = 4, RentDate = new DateTime(2021, 4, 12), ReturnDate = new DateTime(2021, 4, 21) });
            //result = rentalManager.Add(new Rental { Id = 6, CarId = 1, CustomerId = 5, RentDate = new DateTime(2021, 5, 12), ReturnDate = new DateTime(2021, 5, 21) });
            //result = rentalManager.Add(new Rental { Id = 7, CarId = 2, CustomerId = 1, RentDate = new DateTime(2021, 6, 12), ReturnDate = new DateTime(2021, 6, 21) });
            //result = rentalManager.Add(new Rental { Id = 8, CarId = 5, CustomerId = 2, RentDate = new DateTime(2021, 7, 12), ReturnDate = new DateTime(2021, 7, 21) });
            //if (result.Success)
            //{
            //    Console.WriteLine(result.Message);
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}
            //var result2=rentalManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var item in result2.Data)
            //    {
            //        Console.WriteLine( _ = item.Id);
            //    };
            //}
            //Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            //ekle();
            //Listele();
            // Markalar();
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var cars in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(cars.brandname+" "+cars.colorname+" "+cars.dailprice+" "+cars.description);
            //}


            //Console.WriteLine("**********************************ARAÇLARIMIZ***********************************************");
            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var kar in carManager.GetAll())
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}
            //Console.WriteLine("********************************** BrandId=1 olan ARAÇLARIMIZ***********************************************");
            //foreach (var kar in carManager.GetAllByBrandId(1))
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}
            //Console.WriteLine("********************************** DailPrice 50000-100000 arasında olan ARAÇLARIMIZ***********************************************");
            //foreach (var kar in carManager.GetByDailPrice(50000,100000))
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}
            //Console.WriteLine("**********************************ARAÇLARIMIZ***********************************************");
            //CarManager carManager = new CarManager(new InMemoryCarDal());
            //foreach (var kar in carManager.GetAll())
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}
            //Console.WriteLine("**********************************ARAÇLARIMIZ***********************************************");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("**********************************YENİ ARAÇ LİSTESİ**********************************************************");


            //carManager.Add(new Car { Id = 10, BrandId = 4, ColorId = 0, ModelYear = new DateTime(2020, 1, 1), DailyPrice = 350000, Description = "O Km araç" });


            //foreach (var kar in carManager.GetAll())
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}

            //Console.WriteLine("**********************************YENİ ARAÇ LİSTESİ***********************************************");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("**********************************GÜNCELENEN LİSTE**********************************************************");
            //Car car = new Car { Id = 10, BrandId = 4, ColorId = 0, ModelYear = new DateTime(2020, 1, 1), DailyPrice = 350000, Description = "O Km otomobil" };
            //carManager.Update(car);

            //foreach (var kar in carManager.GetAll())
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}
            //Console.WriteLine("**********************************GÜNCELENEN LİSTE**********************************************************");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            //Console.ReadKey();
            //Console.WriteLine("**********************************GÜNCELENEN(silinen) LİSTE**********************************************************");
            //Car car1 = new Car { Id = 10, BrandId = 4, ColorId = 0, ModelYear = new DateTime(2020, 1, 1), DailyPrice = 350000, Description = "O Km otomobil" };
            //carManager.Delete(car1);
            //foreach (var kar in carManager.GetAll())
            //{
            //    Console.WriteLine(kar.Id + "=" + kar.ModelYear.Year + " " + kar.Description + " " + kar.DailyPrice + " TL.");
            //}
            //Console.WriteLine("**********************************GÜNCELENEN(silinen) LİSTE**********************************************************");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("DEVAM ETMEK İÇİN BİR TUŞA BASINIZ.");
            //Console.ReadKey();

        }

        private static void ekle()
        {
            CarsManager carManager = new CarsManager(new EfCarDal());
            var result = carManager.Add(new Car { Id = 5, BrandId = 1, ColorId = 0, DailyPrice = 0, ModelYear = new DateTime(2012, 1, 1), Description = "orjinal" });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            Console.WriteLine("***************");
        }

        private static void Listele()
        {
            CarsManager carManager = new CarsManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.brandname + " " + car.dailprice + " " + car.description);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            Console.WriteLine("-------------------------------Arabalar Listelendi-----------------------------------------------");
        }

        private static void Markalar()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var markalar in result.Data)
            {
                Console.WriteLine(markalar.Name);
            }
            Console.WriteLine("--------------------------------Markalar Listelendi----------------------------------------------");
        }
    }
}
