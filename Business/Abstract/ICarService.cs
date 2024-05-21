using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetCars();
        List<Car> GetById(int id);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetColorsByColorId(int colorId);
        void Add(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}