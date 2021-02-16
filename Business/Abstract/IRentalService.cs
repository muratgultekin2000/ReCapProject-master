using Core.Utilities.Results;
using DataAccess.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetAll();
        IDataResult<List<Rental>> GetAllByCustomerId(int id);
        IDataResult<List<Rental>> GetByRentDate(DateTime minDate, DateTime maxDate);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
        
    }
}
