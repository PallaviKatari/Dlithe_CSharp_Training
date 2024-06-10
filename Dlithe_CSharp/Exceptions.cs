using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Syntax,Logical,Runtime Errors - Exception Handling
    /// try,catch,finally,throw
    /// Exception Class - Base Class
    /// Pre-defined exceptions - SystemException - DivideByZeroException
    /// user-defined exceptions - ApplicationException
    /// </summary>
    internal class Exceptions
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            DivideByZero();
            ExceptionKeywordsDemo();
            Console.ReadLine();
        }

        public static void DivideByZero()
        {
            float result = 0;
            float a =10, b=0;
            try
            {
                result = a / b;
                if(float.IsInfinity(result))
                {
                    Console.WriteLine("Cannot Divide By Zero");
                }
                Console.WriteLine(result);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ExceptionKeywordsDemo()
        {
            int[] num1 = { 1, 2, 3, 4, 5 };
            int[] num2 = { 1, 0, 3 };
            for(int i = 0;i< num1.Length; i++)
            {
                try
                {
                    Console.WriteLine(num1[i] / num2[i]);
                }
                catch(DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("I am finally");
                }
            }
        }
    }

}
