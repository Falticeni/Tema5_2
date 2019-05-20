using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_mai.Clasess
{
    public abstract class Shape
    {
        public double Width { get; set; }
        public double Hight { get; set; }

        public Shape(double width, double hight)
        {
            this.Width = width;
            this.Hight = hight;
        }
        public abstract double CalculateSurface();
    }
}
