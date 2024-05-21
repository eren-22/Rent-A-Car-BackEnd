using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleCarUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            int i= 0;
            foreach (var car in carManager.GetCarDetails())
            {
                i++;
                Console.WriteLine($" {i}.Car \n Model: " + car.CarName + "\n Brand: " + car.BrandName + "\n Color: " + car.ColorName + "\n Daily Price: " + car.DailyPrice + "\n\n");
            }
        }
    }
}