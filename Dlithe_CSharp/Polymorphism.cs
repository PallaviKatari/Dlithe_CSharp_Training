using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Polymorphism-Method Overloading,Method Overriding
    /// </summary>
    internal class Polymorphism
    {
        static void Main(string[] args)
        {
            Overloading overloading = new Overloading();
            overloading.Add();
            overloading.Add(100);
            overloading.Add("John Doe");
            overloading.Add(1, "Peter");
            overloading.Add("Jane Doe", 2);
            overloading.Add(200);
            overloading.Add(3, "Paul");
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Method - many forms -> add() -> various forms
    /// Overloading - Rules -> Method Signature must be implemented according
    /// Method Signature - different datatypes, no: of parameters, sequence/order of parameters
    /// </summary>
    internal class Overloading
    {
        public void Add()
        {
            Console.WriteLine("Method with no parameter");
        }

        public void Add(int a)
        {
            Console.WriteLine("Method with int parameter:" + a);
        }
        public void Add(string name)
        {
            Console.WriteLine("Method with string parameter:" + name);
        }
        public void Add(int id, string name)
        {
            Console.WriteLine($"Method with int:{id},string parameter:{name}");
        }

        public void Add(string ename,int eid)
        {
            Console.WriteLine($"Method with string parameter:{ename},int:{eid}");
        }
    }
    
}
