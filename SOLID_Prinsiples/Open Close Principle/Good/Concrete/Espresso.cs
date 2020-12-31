using SOLID_Prinsiples.Open_Close_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Open_Close_Principle.Good.Concrete
{
    public class Espresso : GoodCoffee
    {
        public override double GetTotalPrice(double amount)
        {
            return amount * 3.25;
        }
    }
}
