using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;


        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }


        public IDataResult<List<Customer>> GetAll()
        {
           
            return new SuccessDataResult<List<Customer>>(_customerDal.GetAll());

        }

        public IDataResult<Customer> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CustomerDetailDto>> GetCustomerDetails()
        {
            return new SuccessDataResult<List<CustomerDetailDto>>(_customerDal.GetCustomerDetails());
        }
    }
}
