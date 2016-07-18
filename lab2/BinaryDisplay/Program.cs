using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    //Unit tests should be in the same solution...not in other one dedicated only for them.
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter int number");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                var binaryStrings = new BinaryString();
                var s = binaryStrings.IntToBinary(num);

                Console.WriteLine("The binary number is " + s + " and the number of 1's is " + binaryStrings.Cnt);
            }
            else
                Console.WriteLine("Not integer number, Parse failed");
        }
    }
}
