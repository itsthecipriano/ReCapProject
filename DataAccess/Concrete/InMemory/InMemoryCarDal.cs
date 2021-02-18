using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=3, ColorId=2, DailyPrice= 525000, ModelYear=1964, Description= "Chevrolet Impala" },
                new Car{Id=2, BrandId=2, ColorId=2, DailyPrice= 400000, ModelYear=2020, Description= "Ford Kuga" },
                new Car{Id=3, BrandId=3, ColorId=1, DailyPrice= 200000, ModelYear=1973, Description= "Chevrolet Belair" },
                new Car{Id=4, BrandId=2, ColorId=3, DailyPrice= 200000, ModelYear=2017, Description= "Ford Focus" },
                new Car{Id=5, BrandId=3, ColorId=4, DailyPrice= 500000, ModelYear=2017, Description= "Ford Wildtrak" }
            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
        }
    }
}
