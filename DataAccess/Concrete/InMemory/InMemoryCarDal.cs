using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car{Id=1, BrandId= 1, ColorId=1 ,ModelYear=2015, Name="Ford Focus 1",DailyPrice= 1000, Description="Ford Focus 2015"},
                new Car{Id=2, BrandId= 1, ColorId=1 ,ModelYear=2016, Name="Ford Fiesta 1",DailyPrice= 1500, Description="Ford Fiesta 2016"},
                new Car{Id=3, BrandId= 2, ColorId=1 ,ModelYear=2017, Name="Fiat Linea 1",DailyPrice= 2000, Description="Fiat Linea 2018"},
                new Car{Id=4, BrandId= 2, ColorId=2 ,ModelYear=2018, Name="Fiat Egea 1",DailyPrice= 2500, Description="Fiat Egea 2019"},
                new Car{Id=5, BrandId= 3, ColorId=3 ,ModelYear=2019, Name="Renault Clio 1",DailyPrice= 3000, Description="Renault Clio 2020"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            CarToUpdate.Id = car.Id;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.Name = car.Name;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
        
    }
}

