using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Open_Close_Principle.Bad
{
    public enum CoffeeType
    {
        FilterCoffee,
        Americano,
        Latte,
        Espresso
    }
    public class BadCoffee
    {
        public double GetTotalPrice(double amount, CoffeeType coffeeType)
        {
            double totalPrice = 0;

            if (coffeeType == CoffeeType.Americano)
            {
                totalPrice += amount * 5.50;
            }
            else if (coffeeType == CoffeeType.Espresso)
            {
                totalPrice += amount * 3.25;
            }
            else if (coffeeType == CoffeeType.FilterCoffee)
            {
                totalPrice += amount * 2.50;
            }
            else if (coffeeType == CoffeeType.Latte)
            {
                totalPrice += amount * 3;
            }
            return totalPrice;
        }
    }
}
