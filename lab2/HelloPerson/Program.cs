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
            Boolean flag = false;


            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("Enter a number between 1-10");

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
