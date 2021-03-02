using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using Core;
using Core.Entities.Concrete;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetUsers();
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);
        IDataResult<List<OperationClaim>> GetClaims(User user);
        IDataResult<User> GetByMail(string email);
    }
}
