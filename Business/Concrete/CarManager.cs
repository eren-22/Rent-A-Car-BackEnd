using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Gerekli şartlar sağlanamamaktadır!!");
            }
        }

        public List<Car> GetById(int id)
        {
            return _carDal.GetAll(p => p.CarId == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.CarDetail();
        }

        public List<Car> GetCars()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetColorsByColorId(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}