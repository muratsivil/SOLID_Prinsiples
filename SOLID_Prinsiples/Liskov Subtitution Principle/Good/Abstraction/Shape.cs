using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Liskov_Subtitution_Principle.Good.Abstraction
{
    public abstract class Shape
    {
        // Common properties that will inherit all classes are written here.
        public virtual int Id { get; set; }
    }
}
