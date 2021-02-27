using Business.Abstract;
using Business.Constans;
using Core.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _imageDal;
        public CarImageManager(ICarImageDal imageDal)
        {
            _imageDal = imageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfNumberOfPictures(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _imageDal.Add(carImage);
            return new SuccessResult();
        }

        
        public IResult Delete(CarImage carImage)
        {
            var imageFile = _imageDal.Get(p => p.CarId == carImage.CarId);
            File.Delete(imageFile.ImagePath);
            _imageDal.Delete(imageFile);
            return new SuccessResult(Messages.ImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_imageDal.GetAll(p => p.CarId == carId));
        }

        public IResult Update(CarImage carImage)
        {
            
            _imageDal.Update(carImage);
            return new SuccessResult(Messages.ImageUpdated);
        }

        private IResult CheckIfNumberOfPictures(int carId)
        {
            var result = _imageDal.GetAll(p=>p.CarId==carId).Count;
            if (result>5)
            {
                return new ErrorResult(Messages.FiveNumberOfPictures);
            }
            return new SuccessResult();
        }

        
    }
}
