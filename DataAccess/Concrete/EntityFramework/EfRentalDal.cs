using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarDbContext>, IRentalDal
    {
        public Rental GetARentalCar(int carId)
        {
            using (RentACarDbContext context = new RentACarDbContext())
            {
                var result = context.Set<Rental>().Where(r => r.CarId == carId && r.ReturnDate == null);
                return result.SingleOrDefault();
            }
        }
    }
}
