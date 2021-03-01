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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ArabalarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ArabalarContext context = new ArabalarContext())
            {
                var result = from c in context.rentals
                             join b in context.car
                             on c.CarId equals b.Id
                             join d in context.brand
                             on b.BrandId equals d.Id
                             join k in context.customers
                             on c.CustomerId equals k.UserId
                             join u in context.Users
                             on k.UserId equals u.Id
                             select new RentalDetailDto
                             {
                                 id = c.Id,
                                 brandname = d.Name,
                                 firsname=u.FirstName,
                                 lastname=u.LastName,
                                 modelyear=b.ModelYear,
                                 dailprice=b.DailyPrice,
                                 rentdate = c.RentDate,
                                 returndate=c.RentDate,
                                 
                             };
                return result.ToList();
            } }
    }
}
