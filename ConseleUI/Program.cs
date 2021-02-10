using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConseleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestByColorId();
            //TestGetAll();
            CarDetailsTest();
        }

        private static void TestGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.ModelName);
            }
        }

        private static void CarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.ModelName + " " + car.BrandName + " " + car.ColorName + " " + car.DailyPrice);
            }
        }

        private static void TestByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(3))
            {
                Console.WriteLine(car.Id);
            }
        }
    }
}
