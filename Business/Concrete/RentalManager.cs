using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RentalManager:IRentalService
    {
        IRentalDal _rentals;
        public RentalManager(IRentalDal rental)
        {
            _rentals = rental;

        }
        public IResult Add(Rental rental)
        {
            
                var result = _rentals.GetAll().Where(r => r.CarId == rental.CarId)
                .FirstOrDefault(r => r.ReturnDate ==Convert.ToDateTime("1.01.0001"));
                if (result == null)
                {
                    _rentals.Add(rental);
                    return new SuccessResult(Messages.AddedOK);
                } else
                {
                    return new ErrorResult("Araç Kiralanamaz.");
                }
            
        }

        public IResult Delete(Rental rental)
        {
            try
            {
                _rentals.Delete(rental);
                return new SuccessResult(Messages.DeletedOK);
            }
            catch
            {
                return new ErrorResult(Messages.DeletedErr);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentals.GetAll(), Messages.ListedOK);
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentals.Get(b => b.Id == id));
        }

        public IResult Update(Rental rental)
        {
            try
            {
                _rentals.Update(rental);
                return new SuccessResult(Messages.UpdatedOK);
            }
            catch
            {
                return new ErrorResult(Messages.UpdatedErr);
            }
        }
    }
}
