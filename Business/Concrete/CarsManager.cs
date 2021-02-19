using Business.Abstract;
using Business.Constans;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarsManager : ICarService
    {
        ICarDal _carDal;

        public CarsManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            return new SuccessResult(Messages.CarAdded);

        }

        public IResult Delete(Car car)
        {
            if (false)
            {
                return new ErrorResult(Messages.CarsNotBeFound);
            }
            else
            {
                _carDal.Delete(car);
                return new SuccessResult(Messages.CarDelete);
            }
            
        }

        public IResult Update(Car car)
        {
            if (false)
            {
                return new ErrorResult(Messages.CarsNotBeFound);
            }
            else
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.CarUpdated);
            }
            
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==2)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListted);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            if (_carDal.GetAll(p => p.BrandId == id).Count==0)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarsNotBeFound);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c=>c.BrandId==id));
        }

        public IDataResult<List<Car>> GetByDailPrice(int min, int max)
        {
            if ((_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max).Count==0))
            {
                return new ErrorDataResult<List<Car>>(Messages.CarsNotBeFound);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.DailyPrice >= min && p.DailyPrice <= max));
            
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.CarsListted);
        }

        
    }
}
