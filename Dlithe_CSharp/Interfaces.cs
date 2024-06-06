using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dlithe_CSharp
{
    /// <summary>
    /// Interface - purely has only abstract methods,properties but not variables
    /// Multiple inheritance can be accomplished through interface
    /// Security is 100%
    /// </summary>
    internal class Interfaces
    {
        static void Main(string[] args)
        {
            IDetails details; //Base - Derived
            IData data;
            details = new Course();
            data = new Course();
            data.Id = 100;
            data.Details = "CSharp training - Basic Level";
            data.DisplayData();
            details.Name = "CSharp";
            details.DisplayDetails();
            details=new Employee();
            details.Name = "John Doe";
            details.DisplayDetails();
            Console.ReadLine();

        }
    }

    /// <summary>
    /// interface - must start with 'I'
    /// </summary>
    interface IDetails
    {
        string Name { get; set; }
        void DisplayDetails();
    }

    interface IData
    {
        int Id { get; set; }
        string Details {  get; set; }
        void DisplayData();
    }

    /// <summary>
    /// Course class is implementing the interface ICourse
    /// </summary>
    internal class Course : IDetails, IData
    {
        public string Name { get; set; }
        
        public int Id { get; set; }
        public string Details { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"Course Name:{Name}");
        }
        public void DisplayData()
        {
            Console.WriteLine($"Course Id:{Id}");
            Console.WriteLine($"Course Details:{Details}");
        }

    }
    internal class Employee : IDetails
    {
        public string Name { get; set; }
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name:{Name}");
        }

    }
}
