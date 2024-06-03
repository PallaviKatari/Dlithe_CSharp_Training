using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class AccessSpecifiers
    {
        //public,private,internal,protected,internal protected
        //public - accessed - anywhere - across applications
        //private - within the class
        //internal - within the application
        //protected - child class - inheritance
        static void Main(string[] args)
        {
            Sample sample = new Sample();
            sample.Display();
            Console.WriteLine(sample.a);
            Console.ReadKey();
        }
    }

    internal class Sample
    {
        internal int a = 10;

        public void Display()
        {
            Console.WriteLine(a);
        }

    }
}
