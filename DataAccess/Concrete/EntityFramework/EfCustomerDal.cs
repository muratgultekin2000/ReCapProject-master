using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ArabalarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            using (ArabalarContext context=new ArabalarContext())
            {
                var result = from c in context.customers
                             join u in context.Users
                             on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 id = c.UserId,
                                 firstname = u.FirstName,
                                 lastname = u.LastName,
                                 email = u.Email,
                                 companyname = c.CompanyName,
                             };
                return result.ToList();
            }
        }

    }
}
