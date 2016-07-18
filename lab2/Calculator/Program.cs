using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        //No unit tests
        //Consider seperating some logics like input and input validation into other seperate methods.
        static void Main(string[] args)
        {
            Calc calc = new Calc();
            Console.WriteLine("Enter tow double numbers and operator");
            Console.WriteLine("For example 1 + 2");
            string str=Console.ReadLine();

            //usually in C# the body of if/else is always in a new line and is always has braces.
            if (str == null) return;
            string[] op = str.Split(' ');

            //No input validation
            double num1 = double.Parse(op[0]);
            double num2 = double.Parse(op[2]);
            char opr = char.Parse(op[1]);
            double res;

            switch (opr)
            {
                case '+':
                {
                     res=calc.Add(num1, num2);
                     break;
                }

                case '-':
                {
                    res=calc.Sub(num1, num2);
                    break;
                }

                case '*':
                    {
                        res=calc.Mul(num1, num2);
                        break;
                    }

                case '/':
                    {
                        res=calc.Div(num1, num2);
                        break;
                    }

                default:
                {
                    Console.WriteLine("Bad operator");
                    return;
                }
            }

            Console.WriteLine(str + " = " + res);
        }
    }
}
