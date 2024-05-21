using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
	public interface IRentalService
	{
        IDataResult<List<Rental>> GetAll();
        IResult Add(Rental entity);
        IResult Delete(Rental entity);
        IResult Update(Rental entity);
    }
}

