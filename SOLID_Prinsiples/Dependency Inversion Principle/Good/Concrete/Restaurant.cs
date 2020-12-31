using SOLID_Prinsiples.Dependency_Inversion_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Dependency_Inversion_Principle.Good.Concrete
{
    public class Restaurant
    {
        List<IProduct> products;
        public Restaurant()
        {
            products = new List<IProduct>();
        }

        public string GenerateInstruction()
        {
            string instruction = string.Empty;

            foreach (var item in products)
            {
                instruction += " " + item.GetCookingInstruction();
            }

            return instruction;
        }
    }
}
