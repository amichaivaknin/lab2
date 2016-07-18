using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quad
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vals = new double[3];

            if (args.Length < 3)
            {
                Console.WriteLine("missed parameters");
                return;
            }

            for (int i = 0; i < 3; i++)
            {
                if (double.TryParse(args[i], out vals[i]))
                    //It's better to add braces, even for onelines. This is the convention in C#
                    continue;
                Console.WriteLine("wrong parameter in place " + i);
                return;
            }

            QuadraticEquation qe = new QuadraticEquation();
            qe.SolveEquation(vals[0], vals[1], vals[2]);
        }
    }
}
