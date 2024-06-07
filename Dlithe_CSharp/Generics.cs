using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// GENERICS - Type Specific Data, depicted in <>
    /// Applied for a class,variable,property,method etc
    /// </summary>
    internal class Generics<T,T1> //int -> T
    {
        public Generics(T num) // T <- int
        {
            Console.WriteLine($"Value is:{num}");
        }

        public void add(T a,T1 b)
        {
            Console.WriteLine($"Result 1:{a}");
            Console.WriteLine($"Result 2:{b}");
        }

        //public Generics(int num) // T <- int
        //{
        //    Console.WriteLine($"Value is:{num}");
        //}
        //public Generics(double num) // T <- int
        //{
        //    Console.WriteLine($"Value is:{num}");
        //}

    }

    internal class GenericDemo
    {
        static void Main(string[] args)
        {
            //Generics<int> generics = new Generics<int>(100);
            //Generics<double> generics1 = new Generics<double>(100.123);
            Generics<int, double> generics = new Generics<int, double>(100);
            generics.add(10, 123.45);
            Console.ReadLine();

        }
    }
}
