using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RuleManager : IRuleService
    {
        public void NameRules(Car car)
        {
            if (car.Description.Length < 2)
            {
                throw new Exception("Name of the car cannot be less than 2 characters");
            }
        }

        public void PriceRules(Car car)
        {
            if (car.DailyPrice <= 0)
            {
                throw new Exception("Daily price of the car must be a positive amount of number");
            }
        }
    }
}
