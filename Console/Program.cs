using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //CarTest();   
            //RentalTest();

        }

        private static void RentalTest()
        {
            Rental rental5 = new Rental {CarId = 5 ,CustomerId = 2, RentDate = new DateTime(2030,10,10,10,00,00) ,
                ReturnDate = new DateTime(2030,11,11,15,12,00)};
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(rental5);
            var result2 = rentalManager.GetRentalDetails();
            if (result.Success == true && result2.Success == true)
            {
                foreach (var rental in result2.Data)
                {
                    Console.WriteLine("{0}/{1}/{2}/{3}", rental.CarName, rental.CustomerName, rental.RentDate, rental.ReturnDate);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
                Console.WriteLine(result2.Message);
            }
        }

        private static void CarTest()
        {
            Car car6 = new Car { Id=6, BrandId = 1, ColorId = 1, DailyPrice = 110, Description ="blabla", ModelYear = 1995, Name = "Right"};
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(car6);
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0}/{1}/{2}/{3}", car.Name,car.BrandName,car.ColorName,car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
