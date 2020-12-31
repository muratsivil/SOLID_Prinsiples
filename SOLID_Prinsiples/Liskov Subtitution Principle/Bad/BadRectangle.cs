using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_Prinsiples.Liskov_Subtitution_Principle.Bad
{
    public class BadRectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }
    }
}
