using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    public class QuadraticEquation
    {
        
        public int SolveEquation(double a, double b, double c)
        {
            double sqrtpart = b * b - 4 * a * c;
            double x1;

            if (sqrtpart < 0)
            {
                Console.WriteLine("No Solutions");
                return 0;
            }

            if ((int)sqrtpart == 0 )
            {
                x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
                Console.WriteLine("One Solution : " + x1);
                return 1;
            }

            x1 = (-b + System.Math.Sqrt(sqrtpart)) / (2 * a);
            var x2 = (-b - System.Math.Sqrt(sqrtpart)) / (2 * a);
            Console.WriteLine("Two Solutions : " + x1 + " " + x2);
            return 2;
        }

    }
}
