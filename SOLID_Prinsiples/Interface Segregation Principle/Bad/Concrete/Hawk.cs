using SOLID_Prinsiples.Interface_Segregation_Principle.Bad;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Interface_Segregation_Principle.Good
{
    public class Hawk : IBird
    {
        public string Fly()
        {
            return "Hawk can fly";
        }

        public string Walk()
        {
            return "Hawk can walk";
        }
    }
}
