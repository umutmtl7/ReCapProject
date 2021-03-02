using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.Id 
                             join u in context.Users
                             on c.UserId equals u.Id
                             join car in context.Cars
                             on r.CarId equals car.Id
                             select new RentalDetailDto
                             {
                                  CarName = car.Name,
                                  CustomerName = u.FirstName + " " + u.LastName,
                                  RentDate = r.RentDate,
                                  ReturnDate = r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
