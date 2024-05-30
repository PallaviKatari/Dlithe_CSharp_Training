using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class Conditional
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conditional Statements");
            // if-else , switch-case
            // simple if, if-else, else if, nested if

            Console.WriteLine("Greater of 2 numbers");
            int num1 = 100, num2 = 200, num3 = 30;
            //Logical operator (&& - and)
            //if(num1 > num2 && num1>num3)
            //{
            //    Console.WriteLine("Num1 is greater");
            //}
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("Num1 is greater");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine("Num2 is greater");
            }
            else
            {
                Console.WriteLine("Num3 is greater");
            }

            Console.WriteLine("Switch-Case");
            Console.WriteLine("Vowels");
            char c = Convert.ToChar(Console.ReadLine());
            switch (c)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine($"{c} is a Vowel");
                    break;

                default:
                    Console.WriteLine($"{c} is Not a vowel");
                    break ;

            }
            Console.ReadLine();
        }
    }
}
