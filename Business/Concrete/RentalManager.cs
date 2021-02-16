using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            if (false)
            {
                return new ErrorResult(Messages.RentalNoAdded);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.RentalAdded);
            }
            
        }

        public IResult Delete(Rental rental)
        {
            if (false)
            {
                return new ErrorResult(Messages.CarsNotBeFound);
            }
            else
            {
                _rentalDal.Delete(rental);
                
                return new SuccessResult(Messages.RentalDelete);
            }
            
        }

        public IResult Update(Rental rental)
        {
            if (false)
            {
                return new ErrorResult(Messages.CarsNotBeFound);
            }
            else
            {
                _rentalDal.Update(rental);
              
                return new SuccessResult(Messages.RentalUpdated);
            }
            
        }

        public IDataResult<List<Rental>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarsListted);
        }

        public IDataResult<List<Rental>> GetByRentDate(DateTime minDate, DateTime maxDate)
        {
            if (_rentalDal.GetAll(p => p.RentDate>=minDate && p.RentDate<=maxDate).Count==0)
            {
                return new ErrorDataResult<List<Rental>>(Messages.RentalBeNotFound);
            }
            return new SuccessDataResult<List<Rental>>( _rentalDal.GetAll(p => p.RentDate >= minDate && p.RentDate <= maxDate));
        }
        //IDataResult<List<Rental>> GetAllByCustomerId(int id);
        public IDataResult<List<Rental>> GetAllByCustomerId(int id)
        {
            if ((_rentalDal.GetAll(p => p.CustomerId==id).Count ==0))
            {
                return new ErrorDataResult<List<Rental>>(Messages.RentalBeNotFound);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(p => p.CustomerId == id));
            
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        
    }
}
