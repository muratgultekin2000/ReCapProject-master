using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ArabalarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ArabalarContext context=new ArabalarContext())
            {
                var result = from c in context.car
                             join b in context.brand
                             on c.BrandId equals b.Id
                             join k in context.carcolor
                             on c.ColorId equals k.Id
                             select new CarDetailDto
                             {
                                 id = c.Id,
                                 brandname = b.Name,
                                 colorname = k.Name,
                                 modelyear = c.ModelYear,
                                 dailprice = c.DailyPrice,
                                 description = c.Description

                             };
                return result.ToList();
            }
        }
    }
}
