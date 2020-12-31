using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Liskov_Subtitution_Principle.Bad
{
    public class BadAreaCalculator
    {
        public static double CalculateRectangleArea(BadRectangle badRectangle)
        {
            return badRectangle.Height * badRectangle.Width;
        }

        public static double CalculateSquareArea(BadSquare badSquare)
        {
            return badSquare.Width * badSquare.Height;
        }
    }
}
