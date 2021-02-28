﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapContext> ,ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            //joins
            using (ReCapContext context = new ReCapContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors
                             on c.ColorId equals cl.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             select new CarDetailDto
                             {
                                 Description = c.Description,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }

        }
    }
}
