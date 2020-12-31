using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Interface_Segregation_Principle.Bad
{
    public interface IBird
    {
        string Fly();
        string Walk();
    }
}
