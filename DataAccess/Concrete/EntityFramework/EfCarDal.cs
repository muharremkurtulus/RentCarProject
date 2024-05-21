using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                var result = from c in context.Cars
                             join c1 in context.Colors
                             on c.ColorId equals c1.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 CarName = c.Name,
                                 BrandName = b.Name,
                                 ColorName = c1.Name,
                                 DailyPrice = c.DailyPrice
                             };

                return result.ToList();


            }
        }
    }
}

