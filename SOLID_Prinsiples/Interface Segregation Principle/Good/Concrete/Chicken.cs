using SOLID_Prinsiples.Interface_Segregation_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Interface_Segregation_Principle.Good.Concrete
{
    public class Chicken : IFlightlessBird
    {
        public string Walk()
        {
            return "Chicken can walk";
        }
    }
}
