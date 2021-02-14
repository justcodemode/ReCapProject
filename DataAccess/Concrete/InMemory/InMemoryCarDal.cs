using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;
		public InMemoryCarDal()
		{
			_cars = new List<Car>
			{
				new Car{ Id=1, BrandId=2679, ColorId=23, ModelYear=1997, DailyPrice=1000, Description="red kartal"},
				new Car{ Id=2, BrandId=2234, ColorId=123, ModelYear=1980, DailyPrice=2000, Description="white civic"},
				new Car{ Id=3, BrandId=2122, ColorId=234, ModelYear=2007, DailyPrice=200, Description="white corolla"},
				new Car{ Id=4, BrandId=2078, ColorId=263, ModelYear=2020, DailyPrice=800, Description="pink i20"},
				new Car{ Id=5, BrandId=2123, ColorId=923, ModelYear=2000, DailyPrice=100, Description="gray corolla"},
				new Car{ Id=6, BrandId=2566, ColorId=463, ModelYear=1999, DailyPrice=300, Description="white accent"}

			};

		}
		public void Add(Car car)
		{
			_cars.Add(car);

		}

		public void Delete(Car car)
		{
			Car carToDelete =  _cars.SingleOrDefault(c=>c.Id == car.Id);

			_cars.Remove(carToDelete);
		}

		public Car Get(Expression<Func<Car, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public List<Car> GetById(int Id)
		{
			return _cars.Where(c => c.Id == Id).ToList();
		}

		public void Update(Car car)
		{
			Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
			carToUpdate.Id = car.Id;
			carToUpdate.BrandId = car.BrandId;
			carToUpdate.ColorId = car.ColorId;
			carToUpdate.ModelYear = car.ModelYear;
			carToUpdate.DailyPrice = car.DailyPrice;
			carToUpdate.Description = car.Description;

		}
	}
}
