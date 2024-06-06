using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Abstraction - Data hiding
    /// Abstraction - Abstract Classes, Interfaces
    /// Security for the application
    /// </summary>
    internal class Abstraction
    {
        static void Main(string[] args)
        {
            EB_Bill eB_Bill; // Base - Derived instantiation
            eB_Bill = new Domestic();
            eB_Bill.GetRate();
            eB_Bill.CalculateBill(100);
            eB_Bill=new Commercial();
            eB_Bill.GetRate();
            eB_Bill.CalculateBill(300);
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Abstract Class - abstract keyword, abstract variables and methods
    /// Abstract class can contain abstract and non-abstract
    /// Cannot create an instance for an abstract class
    /// Abstract classes must be inherited
    /// </summary>
    internal abstract class EB_Bill
    {
        public double rate;

        /// <summary>
        /// Abstract method - Can only be declared, no implementation
        /// Implementation will be given in the derived class
        /// </summary>
        public abstract void GetRate();

        public void CalculateBill(int units)
        {
            Console.WriteLine($"EB Amount is:{rate * units}");
        }

    }
    internal class Domestic : EB_Bill
    {
        /// <summary>
        /// Method Overriding 
        /// </summary>
        public override void GetRate()
        {
            Console.WriteLine("Domestic Plan");
            rate = 5.00;
        }
    }
    internal class Commercial : EB_Bill
    {
        /// <summary>
        /// Method Overriding 
        /// </summary>
        public override void GetRate()
        {
            Console.WriteLine("Commercial Plan");
            rate = 10.00;
        }
    }
}
