using SOLID_Prinsiples.Interface_Segregation_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Interface_Segregation_Principle.Good.Concrete
{
    public class Hawk : IFlyingBird
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
