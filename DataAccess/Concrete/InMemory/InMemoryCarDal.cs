using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear = 2015, DailyPrice=150, Description ="Dizel/Yarı Otomatik"},
                new Car{Id=2, BrandId=2, ColorId=2, ModelYear = 2017, DailyPrice=130, Description ="Dizel/Otomatik"},
                new Car{Id=3, BrandId=3, ColorId=2, ModelYear = 2017, DailyPrice=420, Description ="Benzin/Otomatik"},
                new Car{Id=4, BrandId=4, ColorId=3, ModelYear = 2012, DailyPrice=200, Description ="Dizel/Otomatik"},
                new Car{Id=5, BrandId=5, ColorId=2, ModelYear = 2020, DailyPrice=840, Description ="Hybrid/Otomatik"},
                new Car{Id=6, BrandId=1, ColorId=2, ModelYear = 2020, DailyPrice=500, Description ="Dizel/Otomatik"},
                new Car{Id=7, BrandId=6, ColorId=4, ModelYear = 2018, DailyPrice=330, Description ="Benzinli/Manuel"},
                new Car{Id=8, BrandId=6, ColorId=5, ModelYear = 2017, DailyPrice=350, Description ="Dizel/Otomatik"},
                new Car{Id=9, BrandId=5, ColorId=2, ModelYear = 2019, DailyPrice=770, Description ="Benzinli/Otomatik"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
            _cars.Remove(car);
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

        public List<Car> GetAllByBrand(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }

     
    }
}
