using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Constructor - Special Method
    /// Same name as the class name
    /// no return type
    /// constructor overloading is supported
    /// Destructor - Garbage Collection(feature of CLR - free the unused resources)
    /// </summary>
    internal class Constructors:IDisposable
    {
        public int a;
        public int b;
        /// <summary>
        /// Default Constructor - assigning values to the variable
        /// </summary>
        public Constructors()
        {
            a=10; b=10;
            Console.WriteLine($"Default Constructor - Result:{a + b}");
        }
        public Constructors(int x,int y)
        {
            Console.WriteLine($"Parameterized Constructor - Result:{x + y}");
        }

        /// <summary>
        /// ~ - Tilde symbol
        /// Same name as the class name
        /// no access specifier and return type
        /// only one destructor in a class
        /// Last method to be invoked
        /// Destructor - Finalize() - Implicit
        /// Dispose() - Explicit - To free the unused resources 
        /// (Files,Database) - Open a File/Database
        /// Dispose method - abstract method present in IDisposable Interface
        /// </summary>
        ~Constructors()
        {
            Console.WriteLine("Destructor Invoked");
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose Invoked");
        }
        static void Main(string[] args)
        {
            //Default constructor would be called automatically
            Constructors c = new Constructors();
            Constructors c1 = new Constructors(100,200);
            c1.Dispose();
            Console.ReadLine();

        }
    }
}
