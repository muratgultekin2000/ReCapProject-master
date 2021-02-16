using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService

    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<List<Brand>> GetAll()
        {
            if (false)
            {
                return new ErrorDataResult<List<Brand>>(Messages.BradNotBeFaund);
            }
            else
            {
                return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(), Messages.CarsListted);
            }

        }

        public IDataResult<Brand> GetById(int id)
        {
            if (false)
            {
                return new ErrorDataResult<Brand>(Messages.BradNotBeFaund);

            }
            else
            {
                return new SuccessDataResult<Brand>(_brandDal.Get(b => b.Id == id),Messages.CarsListted);
            }

            
        }

               
    }
}
