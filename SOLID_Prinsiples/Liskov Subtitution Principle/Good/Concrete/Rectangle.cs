using SOLID_Prinsiples.Liskov_Subtitution_Principle.Good.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Liskov_Subtitution_Principle.Good.Concrete
{
    public class Rectangle : Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public double RectangleArea()
        {
            return Width * Height;
        }
    }
}
