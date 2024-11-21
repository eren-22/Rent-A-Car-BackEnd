using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentACarContext>, ICarDal
    {
        public List<CarDetailDto> CarDetails()
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from b in context.Brands
                             join car in context.Cars on b.BrandId equals car.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new CarDetailDto
                             {
                                 Description = car.Description,
                                 BrandName = b.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
