using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_mai.Clasess
{
    public class Square : Shape
    {
        public Square(double width) : base(width, width)
        {
        }
        public override double CalculateSurface()
        {
            return Width * Hight;
        }
    }
}
