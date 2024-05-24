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
            //CarList();
            //CarTest();
            CustomerTest();
        }

        #region Araba DTO' ları yapıldı
        private static void CarList()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            int i = 0;
            foreach (var car in carManager.GetCarDetails().Data)
            {
                i++;
                Console.WriteLine($" {i}.Car \n Model: " + car.CarName + "\n Brand: " + car.BrandName + "\n Color: " + car.ColorName + "\n Daily Price: " + car.DailyPrice + "\n\n");
            }
        }
        #endregion


        #region Result tamamlandı
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        #endregion

        #region Müşteri test
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetCustomers();

            if (result.Success == true)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
            }
            else { Console.WriteLine(result.Message); }
        }
        #endregion

    }
}