using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            CarTest();            
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    System.Console.WriteLine("{0}/{1}/{2}/{3}", car.Name, car.BrandName, car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                System.Console.WriteLine(result.Message);
            }
        }
    }
}
