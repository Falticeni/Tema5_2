using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _17_mai.Clasess;

namespace _17_mai
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle T1 = new Triangle(2, 3);
            Rectangle R1 = new Rectangle(4, 5);
            Square S1 = new Square(6);
            Triangle T2 = new Triangle(1, 3);
            Rectangle R2 = new Rectangle(2, 5);
            Square S2 = new Square(4);
            Triangle T3 = new Triangle(1, 3);
            List<Shape> Figuri = new List<Shape> { T1, T2, R1, S1, R2, S2, T3 };
            AreeCalcul.Print(Figuri);
        }
    }
}
