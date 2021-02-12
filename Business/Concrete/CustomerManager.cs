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
    public class CustomerManager:ICustomerService
    {
        ICustomerDal _customers;
        public CustomerManager(ICustomerDal customer)
        {
            _customers = customer;

        }
        public IResult Add(Customer customer)
        {
            try
            {
                _customers.Add(customer);
                return new SuccessResult(Messages.AddedOK);
            }
            catch
            {
                return new ErrorResult(Messages.AddedErr);
            }
        }

        public IResult Delete(Customer customer)
        {
            try
            {
                _customers.Delete(customer);
                return new SuccessResult(Messages.DeletedOK);
            }
            catch
            {
                return new ErrorResult(Messages.DeletedErr);
            }
        }

        public IDataResult<List<Customer>> GetAll()
        {
            return new SuccessDataResult<List<Customer>>(_customers.GetAll(), Messages.ListedOK);
        }

        public IDataResult<List<Customer>> GetById(int id)
        {
            return new SuccessDataResult<List<Customer>>(_customers.GetAll(c => c.UserId == id));
        }

        public IResult Update(Customer customer)
        {
            try
            {
                _customers.Update(customer);
                return new SuccessResult(Messages.UpdatedOK);
            }
            catch
            {
                return new ErrorResult(Messages.UpdatedErr);
            }
        }
    }
}
