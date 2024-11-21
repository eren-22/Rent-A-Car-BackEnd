using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleAppUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();

            //ColorTest();

            //BrandTest();

            //CarDetails();

            //CarManager carManager = new CarManager(new EfCarDal());

            //var result = carManager.GetCarDetails();

            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //var result = brandManager.GetAll();

            //if (result.Success)
            //{
            //    foreach (var car in result.Data)
            //    {
            //        Console.WriteLine(car.BrandName);
            //    }
            //}

            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            UserManager userManager = new UserManager(new EfUserDal());

            var result = userManager.GetAll();

            if (result.Success)
            {
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.Email);
                }
            }
        }

        //private static void CarDetails()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    foreach (var carDetails in carManager.GetCarDetails())
        //    {
        //        Console.WriteLine(
        //            "Marka: " + carDetails.BrandName +  "\n" +
        //            "Model: " + carDetails.Description + "\n" +
        //            "Renk: " + carDetails.ColorName + "\n" +
        //            "Günlük Fiyat: " + carDetails.DailyPrice + " TL");
        //        Console.WriteLine("---------------------------");
        //    }
        //}

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());

        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        //private static void ColorTest()
        //{
        //    ColorManager colorManager = new ColorManager(new EfColorDal());

        //    foreach (var color in colorManager.GetAll())
        //    {
        //        Console.WriteLine(color.ColorName);
        //    }
        //}

        //private static void CarTest()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());

        //    foreach (var car in carManager.GetAll())
        //    {
        //        Console.WriteLine(car.Description);
        //    }
        //}
    }
}