using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Liskov_Subtitution_Principle.Bad
{
    public class BadSquare : BadRectangle
    {
        int _height;
        int _width;

        public override int Height
        {
            get { return _height; }
            set { _height = value; _width = value; }
        }

        public override int Width
        {
            get { return _width; }
            set { _height = value; _width = value; }
        }
    }
}
