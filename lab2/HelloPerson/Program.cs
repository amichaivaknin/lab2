using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaces = 0;

            //The convention is to use the 'bool' alias of 'Boolean'.
            Boolean flag = false;


            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            //it is better to use formatting. Fortuanatelly, we won't have to use string interpolation or string.Format since Console.WriteLine has an overload that accepts a formatted string
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter a number between 1-10");

            //Consider using do-while loop
            while (flag == false)
            {
                var space = Console.ReadLine();
                spaces = int.Parse(space);
                if (spaces > 10 || spaces < 1)
                {
                    Console.WriteLine("Worng number, insert new number between 1-10");
                    flag = false;
                }
                else
                    //The convention in C# is to add braces for body-expressions even if they are oneliners.
                    flag = true;
            }


            for (int i = 0; i < spaces; i++)
            {
                name = " " + name;
                Console.WriteLine(name);
            }


        }
    }
    
}
