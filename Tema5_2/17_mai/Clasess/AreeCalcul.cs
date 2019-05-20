using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_mai.Clasess
{
    public static class AreeCalcul
    {
        static int countT = 1;  // nr de triunghiuri parcurse
        static int countR = 1;  // nr de dreptunghiuri parcurse
        static int countP = 1;  // nr de patrate parcurse
        public static void Print(List<Shape>Figuri)
        {
            foreach (Shape figura in Figuri)
            {
                if (figura is Triangle)
                {
                    Console.WriteLine("Aria triunghiului nr. {0}  este: {1}.", countT, figura.CalculateSurface());
                    countT++;
                }
                else
                if (figura is Rectangle)
                {
                    Console.WriteLine("Aria dreptunghiului nr. {0}  este: {1}.", countR, figura.CalculateSurface());
                    countR++;
                }
                else
                if (figura is Square)
                {
                    Console.WriteLine("Aria patratului nr. {0}  este: {1}.", countP, figura.CalculateSurface());
                    countP++;
                }
            }
        }
    }
}
