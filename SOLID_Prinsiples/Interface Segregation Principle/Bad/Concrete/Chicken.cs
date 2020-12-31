using SOLID_Prinsiples.Interface_Segregation_Principle.Bad;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Interface_Segregation_Principle.Good
{
    public class Chicken : IBird
    {
        public string Fly()
        {
            return "Chicken cannot fly";
        }

        public string Walk()
        {
            return "Chicken can walk";
        }
    }
}
