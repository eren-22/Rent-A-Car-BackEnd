using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car { CarId = 1, BrandId = 1, ColorId = 1, DailyPrice = 20, Description = "Fiat Egea", ModelYear = 2020 },
                new Car { CarId = 2, BrandId = 1, ColorId = 2, DailyPrice = 10, Description = "BMW 5.20", ModelYear = 2008 },
                new Car { CarId = 3, BrandId = 3, ColorId = 1, DailyPrice = 30, Description = "Dacia Duster", ModelYear = 2011 },
                new Car { CarId = 4, BrandId = 2, ColorId = 3, DailyPrice = 25, Description = "Ford Fiesta", ModelYear = 2006 },
                new Car { CarId = 5, BrandId = 3, ColorId = 2, DailyPrice = 15, Description = "Toyota Corolla", ModelYear = 2015 }
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=> c.CarId == car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public List<CarDetailDto> CarDetail()
        {
            throw new NotImplementedException();
        }
    }
}