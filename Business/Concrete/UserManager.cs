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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal) {
            _userDal = userDal;
        }
        public IResult Add(User user)
        {
            if (false)
            {
                return new ErrorResult(Messages.UserNoAdded);
            }
            else
            {
                _userDal.Add(user);
                return new SuccessResult(Messages.UserAdded);
            }

        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.UserDelete);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), Messages.UserListted);
        }

        public IResult Update(User user)
        {
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
