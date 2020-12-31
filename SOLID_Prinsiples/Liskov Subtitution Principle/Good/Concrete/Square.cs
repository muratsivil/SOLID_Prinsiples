using SOLID_Prinsiples.Liskov_Subtitution_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Liskov_Subtitution_Principle.Good.Concrete
{
    public class Square : Shape
    {
        public int Width { get; set; }

        public double SquareArea()
        {
            return Width * Width;
        }
    }
}
