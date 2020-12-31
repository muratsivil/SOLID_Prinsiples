using SOLID_Prinsiples.Dependency_Inversion_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Dependency_Inversion_Principle.Good.Concrete
{
    public class Poultry : IProduct
    {
        public string GetCookingInstruction()
        {
            return "Poultry Instruction";
        }
    }
}
