using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_mai.Clasess
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double hight) : base(width, hight)
        {
        }
        public override double CalculateSurface()
        {
            return Width * Hight;
        }
    }
}
