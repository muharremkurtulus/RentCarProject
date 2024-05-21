using System;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> GetAll();
        IResult Add(Customer entity);
        IResult Delete(Customer entity);
        IResult Update(Customer entity);
    }
}
