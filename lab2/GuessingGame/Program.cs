using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    //It would have be better to seperate some of the logic into different methods
    class Program
    {
        static void Main(string[] args)
        {
            var count = 1;

            Console.WriteLine("guess the number between 1-100");

            var secret = new Random().Next(1, 101);

            //You could have used a for loop. Could have been easier to count
            while (count <= 7)
            {
                int num;

                Console.WriteLine("you have " + (7-count+1) +" guesses");
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num > 0 && num < 101)
                    {
                        if (num == secret)
                            break;
                        else
                        {
                            Console.WriteLine(num > secret ? "too big" : "too small");
                        }
                    }
                    else
                        Console.WriteLine("Iligal number, enter number between 1-100");
                }

                else
                    Console.WriteLine("String could not be parsed, enter number between 1-100");

                count++;
            }


            Console.WriteLine("the number is " + secret);

            if (count > 7)
                Console.WriteLine("you failed");
            else
                Console.WriteLine("the number of guesses is :" + count);
        }
    }
}
