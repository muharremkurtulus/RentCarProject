using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {


            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.carDetailDtos())
            //{
            //    Console.WriteLine(car.CarName + ": "+ car.BrandName);
            //}

     
            //Console.Write("Araç ID sini giriniz: ");
            //int carId = int.Parse(Console.ReadLine());

            //Console.Write("Color ID sini giriniz: ");
            //int colorId = int.Parse(Console.ReadLine());

            //Console.Write("Brand ID sini giriniz: ");
            //int brandId = int.Parse(Console.ReadLine());

            //Console.Write("Araba ismini giriniz: ");
            //string carName = Console.ReadLine();

            //Console.Write("Model Yılını giriniz: ");
            //int modelYear = int.Parse(Console.ReadLine());

            //Console.Write("Günlük ücret bilgisini giriniz: ");
            //decimal dailyPrice = decimal.Parse(Console.ReadLine());

            //Console.Write("Araba açıklamasını giriniz: ");
            //string description = Console.ReadLine();







            //Car newCar = new Car
            //{
            //    CarId = carId,
            //    ColorId = colorId,
            //    BrandId = brandId,
            //    CarName = carName,
            //    ModelYear = modelYear,
            //    DailyPrice = dailyPrice,
            //    Description = description
            //};


            //CarManager carManager = new CarManager(new EfCarDal());
            // carManager.Add(newCar);
            // carManager.Delete(newCar);


            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.carDetailDtos();

            //if (result.Success)
            //{
            //    foreach (var car in carManager.carDetailDtos().Data)
            //    {
            //        Console.WriteLine(car.CarName + "/" + car.BrandName);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var car in carManager.GetAll().Data)
            //    {
            //        Console.WriteLine(car.Name);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();
            if (result.Success)
            {
                foreach (var customer in customerManager.GetAll().Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }

                Console.WriteLine(result.Message);
            }

            //CarManager carManager = new CarManager(new EfCarDal());
            //var result = carManager.carDetailDtos();
            //if (result.Success)
            //{
            //    foreach (var car in carManager.carDetailDtos().Data)
            //    {
            //        Console.WriteLine(car.CarName + " : " + car.ColorName);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //var result = customerManager.GetAll();
            //if (result.Success)
            //{
            //    foreach (var customer in customerManager.GetAll().Data)
            //    {
            //        Console.WriteLine(customer.CompanyName);
            //    }

            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //Brand newCar = new Brand
            //{

            //    Id = 6
            //};
            //var result = brandManager.Delete(newCar);

            //ColorManager colorManager = new ColorManager(new EfColorDal());
            //Color newColor = new Color
            //{

            //    Name ="Turkuaz"
            //};
            //var result = colorManager.Add(newColor);
        }
    }
}