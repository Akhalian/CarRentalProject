﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public IDataResult<List<User>> GetUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll(), UserMessages.UsersListed);
        }

        public IResult Add(User user)
        {
            _userDal.Add(user);
            return new SuccesResult(UserMessages.UserAdded);
        }

        public IResult Delete(User user)
        {
            _userDal.Delete(user);
            return new SuccesResult(UserMessages.UserDeleted);
        }

        public IResult Update(User user)
        {
            _userDal.Update(user);
            return new SuccesResult(UserMessages.UserUpdated);
        }
    }
}
