using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Helpers.FileHelpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelperService _fileHelperService;

        public CarImageManager(ICarImageDal carImageDal, IFileHelperService fileHelperService)
        {
            _carImageDal = carImageDal;
            _fileHelperService = fileHelperService;
        }

        [ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageLimit(carImage.CarId));

            if (result == null)
            {
                return null;
            }

            carImage.Date = DateTime.Now;

            _carImageDal.Add(carImage);

            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);

            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImageListed);
        }

        public IResult Update(CarImage carImage)
        {
            carImage.Date = DateTime.Now;

            _carImageDal.Update(carImage);

            return new SuccessResult(Messages.CarImageUpdated);
        }

        public IDataResult<CarImage> GetById(int carImageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.CarImageId == carImageId), Messages.CarImageListed);
        }

        public IDataResult<List<CarImage>> GetCarImagesByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == id), Messages.CarImageListed);
        }


        //  -----BUSINESS RULES METHODS-----
        
        public IResult CheckIfCarImageLimit(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;

            if (result > 5)
            {
                return new ErrorResult(Messages.CarImageLimit);
            }
            return new SuccessResult();
        }
    }
}