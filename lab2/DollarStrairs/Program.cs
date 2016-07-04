using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DollarStrairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Enter int number");

            if (int.TryParse(Console.ReadLine(), out num))
            {
                string str = "$";
                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine(str);
                    str += "$";
                }
            }
            else
                Console.WriteLine("Not integer number, Parse failed");
        }
    }
}
