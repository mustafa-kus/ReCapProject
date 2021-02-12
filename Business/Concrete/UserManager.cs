using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _users;
        public UserManager(IUserDal user)
        {
            _users = user;

        }
        public IResult Add(User user)
        {
            try
            {
                _users.Add(user);
                return new SuccessResult(Messages.AddedOK);
            }
            catch
            {
                return new ErrorResult(Messages.AddedErr);
            }
        }

        public IResult Delete(User user)
        {
            try
            {
                _users.Delete(user);
                return new SuccessResult(Messages.DeletedOK);
            }
            catch
            {
                return new ErrorResult(Messages.DeletedErr);
            }
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_users.GetAll(), Messages.ListedOK);
        }

        public IDataResult<User> GetById(int id)
        {
            return new SuccessDataResult<User>(_users.Get(b => b.Id == id));
        }

        public IResult Update(User user)
        {
            try
            {
                _users.Update(user);
                return new SuccessResult(Messages.UpdatedOK);
            }
            catch
            {
                return new ErrorResult(Messages.UpdatedErr);
            }
        }
    }
}
