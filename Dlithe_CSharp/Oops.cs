using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    internal class Oops
    {
        public void instanceMethod1()
        {
            Console.WriteLine("Instance Method - Oops Class");
        }

        public static void staticMethod1()
        {
            Console.WriteLine("Static Method - Oops Class");
        }

        //OOPS - Object Oriented Programming Structure/System
        //Class,Objects,Abstraction,Encapsulation,Polymorphism,Inheritance
        static void Main(string[] args)
        {
            Console.WriteLine("Difference between instance and static method");
            //We are creating an object/instance for the Demo class
            //Object - state,behaviour,identity(unique)
            Demo demo = new Demo();
            demo.instanceMethod();
            Demo.staticMethod();
            Demo demo1 = new Demo();
            demo1.instanceMethod();
            Demo.staticMethod();

            Oops oops = new Oops();
            oops.instanceMethod1();
            staticMethod1();
            Console.ReadLine();

        }
    }

    internal class Demo
    {
        // Functions - Methods
        // Static Method, Instance Method

        public void instanceMethod()
        {
            Console.WriteLine("Instance Method - Demo Class");
        }

        public static void staticMethod()
        {
            Console.WriteLine("Static Method - Demo Class");
        }
    }
}
