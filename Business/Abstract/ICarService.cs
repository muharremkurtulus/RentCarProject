using System;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<Car>> GetByUnitPrice(decimal min,decimal max);
        IResult Add(Car entity);
        IResult Delete(Car entity);
        IResult Update(Car entity);
        IDataResult<List<CarDetailDto>> carDetailDtos();

    }
}

